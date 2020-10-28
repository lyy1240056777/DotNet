using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice3
{
    class Program
    {
        
        static void Main(string[] args){
            using (var db = new OrderContext())
            {
                var order = new Order
                {
                    ID = 1,
                    Client = "b",
                    //DetailsList = new List<OrderDetails>(),
                    Total = 0
                };
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }
    }
}
