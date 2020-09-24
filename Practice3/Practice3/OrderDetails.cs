using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class OrderDetails
    {
        public string Commodity { set; get; }//key
        public double UnitPrice { set; get; }
        public int Amount { set; get; }
        public double TotalPrice { set; get; }
        public override bool Equals(object obj)
        {
            var od = obj as OrderDetails;
            if (od == null)
                return false;
            return Commodity == od.Commodity;
            //return base.Equals(obj);
        }
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
        public OrderDetails() { }
        public OrderDetails(string commodity,double unitPrice,int amount)
        {
            Commodity = commodity;
            UnitPrice = unitPrice;
            Amount = amount;
            TotalPrice = UnitPrice * Amount;
        }
    }
}
