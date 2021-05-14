using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    class Out
    {
        static void Main()
        {
            //Dung out ko Phai gan gia tri
            //Ko can khai bao bien truoc

            /*string name;
            int age;
            float mark;
            GetUserInfo(out name, out age, out mark);*/
            //Thay the bang
            GetUserInfo(out string name, out int age, out float mark);
            ShowReasult(name, age, mark);
        }

        private static void ShowReasult(string name, int age, float mark)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Mark : {mark}");
        }
        private static void GetUserInfo(out string name, out int age, out float mark)
        {
            Console.WriteLine("Your name ?");
            name = Console.ReadLine();
            Console.WriteLine("Your age ?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your mark ?");
            mark = Convert.ToSingle(Console.ReadLine());
        }
    }
}
