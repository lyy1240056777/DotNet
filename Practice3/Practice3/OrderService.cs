using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Practice3
{
    [Serializable]
    public class OrderService
    {
        private List<Order> OrderList { set; get; }
        private int currentID;
        public OrderService()
        {
            OrderList = new List<Order>();
            currentID = 1;
        }
        /*
        public void UpdateOrder(int id,string client)
        {
            var or = OrderList.Find(o => o.ID == id);
            or.Client = client;
            Console.WriteLine("UpdateOrder successful.");
        }*/
        public void Update(int id,string commodity,double unitPrice,int amount)
        {
            var or = OrderList.Where(o => o.ID == id).FirstOrDefault();
            var od = or.DetailsList.Where(o => o.Commodity == commodity).FirstOrDefault();
            if(od==null)
            {
                var odd = new OrderDetails(commodity, unitPrice, amount);
                or.DetailsList.Add(odd);
            }
            else if(amount==0)
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
            Console.WriteLine("UpdateDetails successful.");
        }
        public void Create(string client)
        {
            var or = new Order(currentID, client);
            currentID++;
            OrderList.Add(or);
            Console.WriteLine("Create successful.");
        }
        public void Delete(int id)
        {
            var or = OrderList.Where(o => o.ID == id).FirstOrDefault();
            OrderList.Remove(or);
            if(or==null)
                Console.WriteLine("No order matched.");
            else
                Console.WriteLine("Delete successful.");
        }
        public void ReadOrder(int id)
        {
            var or = OrderList.Where(o => o.ID == id).FirstOrDefault();
            or.Show();
        }
        public void ReadOrder(string client)
        {
            var orl = OrderList.Where(o => o.Client == client).OrderBy(o => o.Total);
            //var orl = OrderList.FindAll(o => o.Client == client);
            foreach (var or in orl)
                or.Show();
        }
        public void ReadDetails(string commodity)
        {
            var orl = from o in OrderList where o.DetailsList.Any(s => s.Commodity == commodity) orderby o.Total select o;
            foreach (var or in orl)
                or.Show();
        }
        public void Interface()
        {
            Console.WriteLine("Enter one number:(1:Create 2:Delete 3:Update 4:ReadOrder 5:ReadDetails)");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("Enter client name:");
                        Create(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Enter order ID:");
                        Delete(Int32.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Enter order ID:");
                        int id = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter new commodity:");
                        string commodity = Console.ReadLine();
                        Console.Write("Enter unitPrice:");
                        double unitPrice = double.Parse(Console.ReadLine());
                        Console.Write("Enter new amount:");
                        int amount = Int32.Parse(Console.ReadLine());
                        Update(id, commodity, unitPrice, amount);
                        break;
                    case 4:
                        Console.Write("Enter key:");
                        string key = Console.ReadLine();
                        try
                        {
                            int k = Int32.Parse(key);
                            ReadOrder(k);
                        }
                        catch (FormatException e)
                        {
                            ReadOrder(key);
                        }
                        break;
                    case 5:
                        Console.Write("Enter commodity:");
                        ReadDetails(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }catch(FormatException e) 
            {
                this.Interface();
            }
        }

        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            FileStream fs = new FileStream("s.xml", FileMode.Create);
            xmlSerializer.Serialize(fs, OrderList);
            fs.Close();
            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText("s.xml"));
            OrderList.Clear();
        }

        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs=new FileStream("s.xml",FileMode.Open))
            {
                List<Order> orders = (List<Order>)xmlSerializer.Deserialize(fs);
                foreach(Order i in orders)
                {
                    OrderList.Add(i);
                }
            }
            Console.WriteLine("\n");
            OrderList.ForEach(i => i.Show());
        }
    }
}
