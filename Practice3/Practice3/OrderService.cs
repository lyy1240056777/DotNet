using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Practice3
{
    public class OrderService
    {
        public List<Order> OrderList { set; get; }
        public int currentID;
        public OrderService()
        {
            OrderList = new List<Order>();
            currentID = 1;
        }
        public bool Update(int id, string commodity, double unitPrice, int amount)
        {
            /*
            var or = OrderList.Where(o => o.ID == id).FirstOrDefault();
            if (or == null) return false;
            var od = or.DetailsList.Where(o => o.Commodity == commodity).FirstOrDefault();
            if (od == null)
            {
                var odd = new OrderDetails(commodity, unitPrice, amount);
                or.DetailsList.Add(odd);
            }
            else if (amount == 0)
            {
                or.DetailsList.Remove(od);
            }
            else
            {
                od.UnitPrice = unitPrice;
                od.Amount = amount;
                od.TotalPrice = unitPrice * amount;
            }
            or.CalculateTotal();
            return true;
            */
            using(var db=new OrderContext())
            {
                var order = db.Orders.Where(s => s.ID == id).FirstOrDefault();
                if (order == null) return false;
                OrderDetails od = new OrderDetails(commodity, unitPrice, amount);
                order.DetailsList.Add(od);

                var orderDetail = order.DetailsList.Where(s => s.Commodity == commodity).FirstOrDefault();
                if (orderDetail == null)
                {
                    order.DetailsList.Add(new OrderDetails
                    {
                        Commodity = commodity,
                        UnitPrice = unitPrice,
                        Amount = amount
                    });
                }
                else if (amount == 0) order.DetailsList.Remove(orderDetail);
                else
                {
                    orderDetail.UnitPrice = unitPrice;
                    orderDetail.Amount = amount;
                    orderDetail.TotalPrice = unitPrice * amount;
                }
                order.CalculateTotal();
                db.SaveChanges();
                return true;
            }
        }
        public void Create(string client)
        {
            /*
            var or = new Order(currentID, client);
            currentID++;
            OrderList.Add(or);
            */
            using(var db=new OrderContext())
            {
                //var order = new Order { Client = client, ID = currentID };
                var order = new Order(currentID, client);
                currentID++;
                db.Orders.Add(order);
                Console.WriteLine(db.Orders.FirstOrDefault(s=>s.ID==1));
                db.SaveChanges();
            }
        }
        public List<Order> GetAllOrders()
        {
            using(var db=new OrderContext())
            {
                return db.Orders.ToList();
            }
        }
        public bool Delete(int id)
        {
            /*
            var or = OrderList.Where(o => o.ID == id).FirstOrDefault();
            OrderList.Remove(or);
            if (or == null)
                return false;
            else
                return true;
                */
            using(var db=new OrderContext())
            {
                var order = db.Orders.Include("DetailsList").FirstOrDefault(s => s.ID == id);
                db.Orders.Remove(order);
                if (order == null)
                    return false;
                else
                    return true;
            }
        }
        //四个查询订单函数
        public List<Order> ReadOrder(int id, List<Order> orders)
        {
            if (id == -1) return orders;
            return orders.Where(o => o.ID == id).ToList();
        }
        public List<Order> ReadOrder(string client, List<Order> orders)
        {
            if (client == "") return orders;
            return orders.Where(o => o.Client == client).OrderBy(o => o.Total).ToList();
        }
        public List<Order> ReadOrder(double down, double up, List<Order> orders)
        {
            if (down == -1 || up == -1) return orders;
            return OrderList.Where(o => o.Total >= down && o.Total <= up).OrderBy(o => o.Total).ToList();
        }
        public List<Order> ReadDetails(string commodity, List<Order> orders)
        {
            if (commodity == "") return orders;
            var orl = from o in OrderList where o.DetailsList.Any(s => s.Commodity == commodity) orderby o.Total select o;
            return orl.ToList();
        }
    }

    //xml序列化类
    public class xml_serializer_manager
    {
        public void serialize_to_xml(string path, object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            string content = string.Empty;
            //serialize
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                content = writer.ToString();
            }
            //save to file
            using (StreamWriter stream_writer = new StreamWriter(path))
            {
                stream_writer.Write(content);
            }
        }

        public object deserialize_from_xml(string path, Type object_type)
        {
            XmlSerializer serializer = new XmlSerializer(object_type);
            using (StreamReader reader = new StreamReader(path))
            {
                return serializer.Deserialize(reader);
            }
        }
    }
}

