using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice3
{
    public class Order
    {
        [Key,Column(Order=1)]
        public int ID { set; get; }
        [Required]
        public string Client { set; get; }
        public double Total { set; get; }
        public List<OrderDetails> DetailsList { set; get; }
        public override bool Equals(object obj)
        {
            var or = obj as Order;
            if (or == null)
                return false;
            return ID == or.ID;
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public override string ToString()
        {
            return ID.ToString();
        }
        public Order() 
        {
            DetailsList = new List<OrderDetails>();
        }
        public Order(int id,string client)
        {
            DetailsList = new List<OrderDetails>();
            ID = id;
            Client = client;
            var tt = from od in DetailsList select od.TotalPrice;
            Total = 0;
            foreach (double t in tt)
                Total += t;
        }
        public void CalculateTotal()
        {
            var tt = from od in DetailsList select od.TotalPrice;
            Total = 0;
            foreach (double t in tt)
                Total += t;
        }
    }
}
