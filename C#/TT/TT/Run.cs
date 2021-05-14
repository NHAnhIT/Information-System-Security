using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    class Run
    {
        static void Main(string[] args)
        {
            Student st = new Student("3118410011", "Hoang Anh", 20, "abc.com");

            // cach 1 dung set get
            /*st.SetAge(21);
            Console.WriteLine("New Age : " + st.GetAge());*/

            // cach 2 dung properties
            st.Name = "Jade Nguyen";
            Console.WriteLine("New Name : " + st.Name);

            // cach 3 nen dung
            st.Age++;
            Console.WriteLine("New Age : " + st.Age);

            // read only 
            //st.Id = "123";  báo lỗi do id chỉ đọc chứ ko thẻ thay đổi

            // write only
                //st.Password == "my password ";  báo lỗi do ko thể lấy ra so sánh




             


        }
    }
}
