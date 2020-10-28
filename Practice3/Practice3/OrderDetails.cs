using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice3
{
    public class OrderDetails
    {
        [Key,Column(Order=1)]
        public string Commodity { set; get; }
        [Required]
        public double UnitPrice { set; get; }
        public int Amount { set; get; }
        public double TotalPrice { set; get; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public override bool Equals(object obj)
        {
            var od = obj as OrderDetails;
            if (od == null)
                return false;
            return Commodity == od.Commodity;
            //return base.Equals(obj);
        }
        /*
        public override int GetHashCode()
        {
            return Commodity.GetHashCode();
            //return base.GetHashCode();
        }
        public override string ToString()
        {
            return Commodity+" "+Amount;
            //return base.ToString();
        }
        */
        public OrderDetails() { }
        public OrderDetails(string commodity,double unitPrice,int amount)
        {
            Commodity = commodity;
            UnitPrice = unitPrice;
            Amount = amount;
            TotalPrice = UnitPrice * Amount;
        }
        public OrderDetails(OrderDetails od)
        {
            this.Commodity = od.Commodity;
            this.UnitPrice = od.UnitPrice;
            this.Amount = od.Amount;
            this.TotalPrice = od.TotalPrice;
        }
    }
}
