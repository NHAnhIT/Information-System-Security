using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    class CungHoangDao
    {
        static void Main (String[] args)
        {
            String choice = "";
            do
            {   
                    int day = 0;
                    int month = 0;
                    int year = 0;
                    while (true)
                    {
                        Console.WriteLine("Nhap ngay sinh ");
                        day = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Nhap thang sinh ");
                        month = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Nhap nam sinh ");
                        year = Convert.ToInt32(Console.ReadLine());

                        if(month == 2 && year%4 != 0 && day >= 1 && day <= 28)
                        {
                            break;
                        }
                        if (month == 2 && year % 4 == 0 && day >= 1 && day <= 29)
                        {
                            break;
                        }
                        if((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day >= 1 && day <= 31)
                        {
                            break;
                        }
                        if((month == 4 || month == 6 || month == 9 || month == 11) && day >= 1 && day <= 30)
                        {
                            break;
                        }
                    }
                String result = "";
                switch (month)
                {
                    case 1:
                        if(day >=20)
                        {
                            result = "Bao Binh";
                        }
                        else
                        {
                            result = "Ma Ket";
                        }
                        break;
                    case 2:
                        result = (day >= 19) ? "Song Ngu" : "Bao Binh";
                        break;
                    case 3:
                        result = (day >= 21) ? "Bach Duong" : "Song Ngu";
                        break;
                    case 4:
                        result = (day >= 21) ? "Kim Nguu" : "Bach Duong";
                        break;
                    case 5:
                        result = (day >= 21) ? "Song Tu" : "Kim Nguu";
                        break;
                    case 6:
                        result = (day >= 22) ? "Cu Giai" : "Song Tu";
                        break;
                    case 7:
                        result = (day >= 23) ? "Su Tu" : "Cu Giai";
                        break;
                    case 8:
                        result = (day >= 23) ? "Xu Nu" : "Su Tu";
                        break;
                    case 9:
                        result = (day >= 23) ? "Thien Binh" : "Xu Nu";
                        break;
                    case 10:
                        result = (day >= 24) ? "Bo Cap" : "Thien Binh";
                        break;
                    case 11:
                        result = (day >= 23) ? "Nhan Ma" : "Bo Cap";
                        break;
                    case 12:
                        result = (day >= 22) ? "Ma Ket" : "Nhan Ma";
                        break;
                }
                Console.WriteLine("Cung Hoang Dao Cua Ban :" + result);
                Console.WriteLine("Nhap X neu muon Thoat && C neu Tiep tuc");
                choice = Console.ReadLine();
                if (choice.ToLower() == "x")
                {
                    System.Environment.Exit(0);
                }

            }
            while (true);
        }
    }
}
