using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TT
{
    class StopTime
    {
        /*Đếm thời gian theo dạng 00 phút 00 giây
        reset time  
        tạm dừng time
        show time*/
        /* static void Main(string[] args)
         {
             Random rand = new Random();
             int i = 0;
             //Console.BackgroundColor = ConsoleColor.Red;
             while (true)
             {
                 i ++;
                 Thread.Sleep(100);
                 //Console.ForegroundColor = ConsoleColor.White;
                 Console.SetCursorPosition(rand.Next(0,100), rand.Next(0, 100));
                 Console.WriteLine(i.ToString("Thao Anh"));
             }
             Console.ReadLine();
         }*/
        DateTime oldTime;
        DateTime newTime;
        TimeSpan currentTime;
        private bool isResume = true;
        
        public StopTime()
        {
            oldTime = DateTime.Now;
            newTime = DateTime.Now;
        }
       
        public void StartTime()
        {
            oldTime = DateTime.Now;
            CountTime();
        }
        public void ResetTime()
        {
            oldTime = DateTime.Now; 

        }

        public void CountTime()
        {
            if (!isResume)
                return;
            newTime = DateTime.Now;
            currentTime = newTime - oldTime;

        }

        public void PauseTime()
        {
            isResume = !isResume;

        }

        public void ShowTime(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(currentTime.Minutes + ":" + currentTime.Seconds);
        }




    }
}
