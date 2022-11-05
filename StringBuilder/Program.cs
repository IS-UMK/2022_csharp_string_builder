using System;

namespace Napisy
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Witaj Świecie";
            string s2 = "" ;

            int k = 10000;

            DateTime t1 = DateTime.Now;

            for (int i = 0; i < k; i++)
            {
                s2 += s;
            }

            DateTime t2 = DateTime.Now;
            TimeSpan dt = t2 - t1;

            Console.WriteLine("Łączenie napisów za pomocą dodawania.");
            Console.WriteLine("Czas łączenia napisów {0} ms.", dt.TotalMilliseconds);
            Console.WriteLine("Długość końcowego napisu {0}", s2.Length);

            t1 = DateTime.Now;
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
           
            for (int i = 0; i < k; i++)
            {
                sb.Append(s);    
            }

            t2 = DateTime.Now;
            dt = t2 - t1;
            Console.WriteLine("Łączenie napisów za pomocą StringBuilder."); 
            Console.WriteLine("Czas łączenia napisów {0} ms.", dt.TotalMilliseconds);
            s2 = sb.ToString();
            Console.WriteLine("Długość końcowego napisu {0}", s2.Length);
        }
    }
}
