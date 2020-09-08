using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._3
{
    class Program
    {
        private static void Filter(bool[] primes)
        {
            for(int num=2;num*num<=primes.Length;num++)
            {
                if (!primes[num])
                    continue;
                for (int multiples = 2 * num; multiples < primes.Length; multiples += num)
                    primes[multiples] = false;
            }
        }
        static void Main(string[] args)
        {
            const int N = 100;
            bool[] primes = new bool[N + 1];
            for (int i = 2; i < N + 1; i++)
                primes[i] = true;
            Filter(primes);
            Console.WriteLine($"2-{N}以内的素数有：");
            for (int num = 2; num < N + 1; num++)
                if (primes[num])
                    Console.Write(num + "  ");
        }
    }
}
