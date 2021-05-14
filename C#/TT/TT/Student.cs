using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    class Student
    {
        private string id;
        private string password;
        private string name;
        private int age;
        private string email;
        //private string address;
        
        public Student()
        {

        }
        public Student(string id, string name, int age, string email)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
        }

        // làm Set Get
        /*public void SetAge( int newAge)
        {
            if(newAge < 0)
            {
                Console.WriteLine("Tuoi cua ban ko hop le");
            }
            else
            {
                age = newAge;
            }
        }
        public int GetAge()
        {
            return this.age;
        }*/


        // Cách 2 làm dạng properties
        public string Name 
        { 
            get { return name; }
            set
            {
                if(value.Length > 0 && value.Length < 50)
                {
                    name= value;
                }
                else
                {
                    Console.WriteLine("Ten ko hop le");
                }
            }
        }

        //cách 3 nên dùng
        public int Age
        {
            get => age;
            set
            {
                if(value > 0 )
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Khong hop le");
                }
            }
        }

        // cách 3.2
        public string Email
        {
            get => email;
            set => email = value;
        }

        // auto properties
        // có thể bỏ get nhưng ko thể bỏ set
        public string Address { get; set; }

        // read only -> chỉ dùng get (dung cho id)
        public string Id
        {
            get => id;
        }
        
        // write only -> chỉ dùng set (dung cho pass)

        public string Password
        {
            set => password = value;
        }



    }
}
