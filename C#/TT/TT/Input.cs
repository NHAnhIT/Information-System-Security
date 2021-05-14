using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    class Input
    {
        static void Main (String[] args)
        {
            Console.WriteLine("What's your name ?");
            String name = Console.ReadLine();

            Console.WriteLine("How old are you ?");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Avg Mark");
            float avgMark = Convert.ToSingle(Console.ReadLine());
            //float avgMark = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("Nice to meet you " + name );
            Console.WriteLine("Your age : " + age);
            Console.WriteLine("Your AVG Mark : " + avgMark);


            //Tinh toan 
            Console.WriteLine("a & b ??");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
                // Cach 1
            Console.WriteLine("Tong " + a + " + " + b + " = "  + sum);
                // Cach 2
            Console.WriteLine("Tong {0} + {1} = {2}", a, b, sum);
                // Cach 3
            Console.WriteLine($"Tong {a} + {b} = {sum} ");


        }
    }
}
