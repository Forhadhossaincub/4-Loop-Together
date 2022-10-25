using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Loop_Together
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("____________For Loop_______________");

            long sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} \t");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum 1 to 10 is : {sum}");

            
            Console.WriteLine("____________While Loop_______________");

            sum = 0;
            int j = 1;
            while(j <= 10)
            {
                Console.Write($"{j} \t");
                sum += j;
                j++;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum 1 to 10 is : {sum}");

            Console.WriteLine("____________Do While Loop_______________");

            sum = 0;
            int k = 1;
            do
            {
                Console.Write($"{k} \t ");
                
                sum += k;
                k++;


            } while (k <= 10);

            Console.WriteLine();
            Console.WriteLine($"Sum 1 to 10 is : {sum}");

            Console.WriteLine("____________For Each Loop_______________");

            foreach(var name in "University")
            {
                Console.Write(name.ToString().ToUpper() + " ");
            }

            Console.WriteLine();

            string[] uName = new string[5] {"Brack", "IUB", "UTU","AU", "BUBT"};


            foreach (var n in uName)
            {
                Console.Write($" {n} ");
            }

            Console.WriteLine();

            string[] sName =  { "Arif", "Saif", "Forhad" };
            
            foreach(var n in sName)
            {
                Console.Write($" {n} ");
            }


            Console.ReadKey();

        }//Main
    }//Class
}//Namespace
