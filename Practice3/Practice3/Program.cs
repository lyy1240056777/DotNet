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
        
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            bool isContinue = true;
            do
            {
                os.Interface();
                Console.WriteLine("Continue?y/n");
                if (Console.ReadLine() == "n")
                    isContinue = false;
            } while (isContinue);
            os.Export();
            os.Import();
            //Console.WriteLine(File.ReadAllText("s.xml"));
        }
    }
}
