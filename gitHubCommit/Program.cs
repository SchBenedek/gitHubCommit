using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitHubCommit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>lista= new List<int>();
            Console.WriteLine("Egy számot: ");
            int a=Convert.ToInt32(Console.ReadLine());
            string b = "";
            while (a!=0)
            {
                b = "";
                foreach(var item in lista)
                {
                    b += (item+", ");
                }
                Console.WriteLine(b);
                Console.WriteLine("Egy számot: ");
                a=Convert.ToInt32(Console.ReadLine());
                lista.Add(a);
            }
            int c = 0;
            foreach(var item in lista)
            {
                if (item > c)
                {
                    c = item;
                }
            }
            Console.WriteLine("legnagyobb: "+c);
            

            List<int> lista2 = new List<int>();
            Console.WriteLine("Egy számot: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            string b2 = "";
            while (a2 != 0)
            {
                b2 = "";
                foreach (var item in lista)
                {
                    b2 += (item + ", ");
                }
                Console.WriteLine(b2);
                Console.WriteLine("Egy számot: ");
                a2 = Convert.ToInt32(Console.ReadLine());
                lista.Add(a2);
             int c2 = 0;
                foreach (var item in lista)
                {
                    if (item > c2)
                    {
                        c2 = item;
                    }
                }
                Console.WriteLine("legnagyobb: " + c2);

                Console.ReadKey();
            }
        }
    }
}
