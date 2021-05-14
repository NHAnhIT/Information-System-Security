using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    class Ref
    {
        static void Main()
        {
            //Dung ref Phai gan gia tri
            // can khai bao bien truoc

            string name = "";
            int age = default;
            float mark = 8.0f;
            GetUserInfo(ref name, ref age, ref mark);
            ShowReasult(name, age, mark);
        }

        private static void ShowReasult(string name, int age, float mark)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Mark : {mark}");
        }
        private static void GetUserInfo(ref string name, ref int age, ref float mark)
        {
            // dung out bat buoc phai gan
            Console.WriteLine("Your name ?");
            name = Console.ReadLine();
            Console.WriteLine("Your age ?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your mark ?");
            mark = Convert.ToSingle(Console.ReadLine());
        }
    }
}

