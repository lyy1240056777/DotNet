using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._1
{
    class Program
    {
        private static List<int> Factorize(int num)
        {
            List<int> factors = new List<int>();
            for(int factor=2;factor*factor<=num;factor++)
                while(num%factor==0)
                {
                    factors.Add(factor);
                    num = num / factor;
                }
            if (num != 1)
                factors.Add(num);
            return factors;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入一个整数：");
                int num = Convert.ToInt32(Console.ReadLine());
                List<int> factors = Factorize(num);
                Console.Write("素因子有：");
                factors.Distinct().ToList().ForEach(f => Console.Write(f+"\t"));
            }
            catch(Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }
        }
    }
}
