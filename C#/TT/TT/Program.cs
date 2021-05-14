using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TT
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            string menu = "\t ---------- Menu ---------- \n"
                + "\t0.Thoat \n"
                + "\t1.Nhap va xuat co ban. \n"
                + "\t2.Chang hay le va chia het cho 3 hay khong. \n"
                + "\t3.Máy tính và So sánh. \n"
                + "\t4.max & min & max2. \n"
                + "\t5.Diện tích & Chu vi hcn. \n"
                + "\t6.Phương trình bậc nhất và Bậc hai. \n"
                + "\t7.Tam giac. \n"
                + "\t8.Luy thua. \n"
                + "\t9.Chia tien. \n"
                + "\t10.So nguyen to. \n"
                + "\t11.Xoa ky tu. \n";
            Console.WriteLine(menu);

            bool kt = false;

            while (!kt)
            {
                Console.WriteLine("Vui long nhap yeu cau :");
                string yeucau = Console.ReadLine();

                switch (yeucau)
                {
                    case "0":
                        kt = true;
                        break;
                    case "1":
                        kt = true;
                        cau1();
                        break;
                    case "2":
                        kt = true;
                        cau2();
                        break;
                    case "3":
                        kt = true;
                        cau3();
                        break;
                    case "4":
                        kt = true;
                        cau5();
                        break;
                    case "5":
                        kt = true;
                        cau7();
                        break;
                    case "6":
                        kt = true;
                        cau9();
                        break;
                    case "7":
                        kt = true;
                        tamgiac();
                        break;
                    case "8":
                        kt = true;
                        luythua();
                        break;
                    case "9":
                        kt = true;
                        chiatien();
                        break;
                    case "20":
                        kt = true;
                        sntn();
                        break;
                    case "11":
                        kt = true;
                        xoachuoi();
                        break;
                    default:
                        Console.WriteLine("Ban nhap sai . Vui long nhap lai ^ ^ !");
                        break;
                }
            }
        }
        static void cau1()
        {
            Console.WriteLine("What do you want to write ??");
            String cau1 = Console.ReadLine();
            Console.WriteLine($"blin blin {cau1}");
        }
        static void cau2()
        {
            Console.WriteLine("n = ???");
            int n = Convert.ToInt32(Console.ReadLine());
            String cau2a = default;
            String cau2b = default;
            cau2a = (n % 2 == 0) ? "Chan" : "Le";
            cau2b = (n % 3 == 0) ? "Chia het cho 3" : "Khong chia het cho 3";
            Console.WriteLine(cau2a);
            Console.WriteLine(cau2b);
        }
        static void cau3()
        {
            Console.WriteLine("*------* May Tinh *------*");
            int choose = 0;
            int a = default;
            int b = default;
            int c = default;
            Console.WriteLine("a = ??? and b = ???");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" a = {a}");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" b = {b}");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("1 . + ");
            Console.WriteLine("2 . - ");
            Console.WriteLine("3 . * ");
            Console.WriteLine("4 . / ");
            Console.WriteLine("What is your choose ??");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine($" Tong : {a} + {b} = {a + b}");
                    break;
                case 2:
                    c = (a >= b) ? a - b : b - a;
                    Console.WriteLine($" Tong : {a} - {b} = {c}");
                    break;
                case 3:
                    Console.WriteLine($" Tong : {a} * {b} = {a * b}");
                    break;
                case 4:
                    /*c = (b == 0) ? (String)"khong the chia" : (float)a / b;
                    Console.WriteLine($" Tong : {a} / {b} = {c}");*/
                    if (b == 0)
                    {
                        Console.WriteLine("khong the chia");
                    }
                    else
                    {
                        Console.WriteLine($" Tong : {a} / {b} = {(float)a / b}");
                    }
                    break;
                default:
                    Console.WriteLine("Khong ton tai ");
                    break;

            }



            // Cau 4
            Console.WriteLine("So sanh ----------");
            if (a > b)
            {
                Console.WriteLine($"{a} > {b}");
            }
            else if (a == b)
            {
                Console.WriteLine($"{a} = {b}");
            }
            else
            {
                Console.WriteLine($"{a} < {b}");
            }
        }
        static void cau5()
        {

            // Cau 5
            int a1 = default;
            int b1 = default;
            int c1 = default;
            int d1 = default;
            Console.WriteLine("a1 = ???");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b1 = ???");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c1 = ???");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d1 = ???");
            d1 = Convert.ToInt32(Console.ReadLine());
            int[] num = { a1, b1, c1, d1 };
            int min = num[0];
            int max = num[0];
            if (a1 == b1 && b1 == c1 && c1 == d1)
            {
                Console.WriteLine("ko co max min");
            }
            else
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] <= min)
                    {
                        min = num[i];
                    }
                    if (num[i] >= max)
                    {
                        max = num[i];

                    }

                }
                Console.WriteLine("Min :" + min);
                Console.WriteLine("Max : " + max);
            }

            // Tìm max2

            int max2 = min;
            if (max2 < a1 && a1 != max)
            {
                max2 = a1;
            }
            if (max2 < b1 && b1 != max)
            {
                max2 = b1;
            }
            if (max2 < c1 && c1 != max)
            {
                max2 = c1;
            }
            if (max2 < d1 && d1 != max)
            {
                max2 = d1;
            }
            Console.WriteLine("Max 2 :" + max2);
        }
        static void cau7()
        {
            float cd = default;
            float cr = default;
            Console.WriteLine("Chieu dai ?");
            cd = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Chieu rong ?");
            cr = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Chu vi = {(cd + cr) * 2}");
            Console.WriteLine($"Dien tich = {cd * cr}");
        }
        static void cau9()
        {
            // Cau 9
            float x1 = default;
            float x2 = default;
            float x3 = default;
            Console.WriteLine("Nhap a ");
            float a2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap b ");
            float b2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap c ");
            float c2 = Convert.ToSingle(Console.ReadLine());
            if (a2 == 0 && b2 == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else if (a2 == 0 && b2 != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                x1 = (-b2 * 1.0f) / a2;
                Console.WriteLine($"x1 = {x1}");
            }

            // Phuong trinh bac 2

            if (a2 == 0)
            {
                if (b2 == 0 && c2 == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else if (b2 == 0 && c2 != 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    x2 = (-c2 * 1.0f) / b2;
                    Console.WriteLine($"x = {x2}");
                }
            }
            else
            {
                float delta = b2 * b2 - 4 * a2 * c2;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep" + (-b2 * 1.0f) / (2 * a2));
                }
                else
                {
                    x2 = (float)(-b2 - Math.Sqrt(delta)) / (2 * a2);
                    x3 = (float)(-b2 + Math.Sqrt(delta)) / (2 * a2);

                    Console.WriteLine("Nghiem cua phuong trinh la x1 = : " + x2);
                    Console.WriteLine("Nghiem cua phuong trinh la x2 = : " + x3);
                }

            }
        }
        static void tamgiac()
        {
            // Cau tam giac
            Console.WriteLine("Nhap 3 canh tam giac");
            int a3 = Convert.ToInt32(Console.ReadLine());
            int b3 = Convert.ToInt32(Console.ReadLine());
            int c3 = Convert.ToInt32(Console.ReadLine());
            if (a3 < b3 + c3 && b3 < a3 + c3 && c3 < a3 + b3)
            {
                if (a3 * a3 == b3 * b3 + c3 * c3 || b3 * b3 == c3 * c3 + a3 * a3 || c3 * c3 == a3 * a3 + b3 * b3)
                {
                    Console.WriteLine("Tam Giac Vuong");
                }
                else if (a3 == b3 && b3 == c3)
                {
                    Console.WriteLine("Tam Giac Deu");
                }
                else if (a3 == b3 || a3 == c3 || c3 == b3)
                {
                    Console.WriteLine("Tam Giac Can");
                }
                else if (a3 * a3 > b3 * b3 + c3 * c3 || b3 * b3 > c3 * c3 + a3 * a3 || c3 * c3 > a3 * a3 + b3 * b3)
                {
                    Console.WriteLine("Tam Giac Tu");
                }
                else
                {
                    Console.WriteLine("Tam Giac Nhon");
                }

            }
            else
            {
                Console.WriteLine("Ba canh a b c khong phai la tam giac");
            }

        }
        static void luythua()
        {
            long x, y, kq;
            Console.WriteLine("nhap x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap y :");
            y = Convert.ToInt32(Console.ReadLine());

            kq = (long)Math.Pow((double)x, (double)y);

            Console.WriteLine("Luy thua x^y = " + kq);

        }
        static void chiatien()
        {
            // Thuat toan vét cạn
            // có tờ 1000, 2000, 5000, 10000, 20000, 500000 xuất tất cả các cách chia tiền ra 5 loại đó
            long tongtien;
            int k1 = 1000;
            int k2 = 2000;
            int k5 = 5000;
            int k10 = 10000;
            int k20 = 20000;
            Console.WriteLine("Nhap tien");
            tongtien = Convert.ToInt64(Console.ReadLine());

            for(int i = 0; i <= tongtien/k1; i++)
            {
                for (int j = 0; j <= tongtien / k2; j++)
                {
                    for (int k = 0; k <= tongtien / k5; k++)
                    {
                        for (int l = 0; l <= tongtien / k10; l++)
                        {
                            for (int m = 0; m <= tongtien / k20; m++)
                            {
                                if(i*k1 + j*k2 + k*k5 + l*k10 + m*k20 == tongtien)
                                {
                                    Console.WriteLine($" {i} to {k1} | {j} to {k2} | {k} to {k5} | {l} to {k10} | {m} to {k20}");
                                }
                            }
                        }
                    }
                }
            }


        }
        static bool snt(int n)
        {

            if (n < 2)
                return false;
            if (n == 2)
                return true;
            for(int i =2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void sntn()
        {
            int n;
            Console.WriteLine("nhap n");
            n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 0; i <=n; i++)
            {
                if (snt(i) == true)
                {
                    Console.WriteLine($"{i} la so nguyen to ");
                    count++;
                }
            }
            Console.WriteLine($"co {count} so nguyen to");
        }
        static void xoachuoi()
        {
            
            Console.WriteLine("Nhap chuoi");
            string a = Console.ReadLine();

            for(int i =0; i <= a.Length; i++)
            {
                if(a[i] == 'a')
                {
                    a = a.Remove(i, 1);
                }

            }
            Console.WriteLine(a);


        }

    }
}
