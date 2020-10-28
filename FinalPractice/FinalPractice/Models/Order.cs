using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FinalPractice.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Client { get; set; }
        public double Total { get; set; }
    }
    public class OrderDetails
    {
        [Key]
        public string Item { get; set; }
        public double UnitPrice { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
