using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWord
{
    class Program
    {
        public static void timSoLonNhat()
        {
            int so1, so2, so3;
            Console.WriteLine("Nhap so 1: ");
            so1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so 2: ");
            so2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so 3: ");
            so3 = Int32.Parse(Console.ReadLine());
            if (so1 > so2)
            {
                if (so1 > so3)
                {
                    Console.WriteLine("So 1 la so lon nhat");
                }
                else
                {
                    Console.WriteLine("So 3 la so lon nhat");
                }

            }
            else
            {
                if (so2 > so3)
                {
                    Console.WriteLine("So 2 la so lon nhat");
                }
                else
                {
                    Console.WriteLine("So 3 la so lon nhat");
                }
            }
        }
        public static void inRaTongnSo()
        {
            int N;
            Console.WriteLine("Nhap vao N: ");
            N = Int32.Parse(Console.ReadLine());
            int Tong = 0;
            for(int i = 0; i <= N; i++)
            {
                Tong += i;
            }
            Console.WriteLine("Tong 1-N la: {0} ", Tong);
        }
        
        public static void inRaChuoiNhiPhan()
        {
            int N;
            Console.WriteLine("Nhap vao so N: ");
            N = Int32.Parse(Console.ReadLine());
            List<int> xau = new List<int>(); 
            int t = 0;
            while (N > 0)
            {
                t = N % 2;
                xau.Add(t);
                N /= 2;
            }
            xau.Reverse();

            Console.WriteLine("Xau nhi phan: ");
            for(int i = 0; i < xau.Count; i++)
            {
                Console.Write(xau[i]);
            }
        }
       public static void printUoc()
        {
             Console.Write("Nhap vao so nguyen duong: ");
            int soN = Int32.Parse(Console.ReadLine());
            if (soN<=0) Console.WriteLine("Khong co uoc");
          
            int uoc = 1;
            Console.WriteLine("Ds cac uoc: ");
            while (uoc <= soN)
            {
                if (soN % uoc == 0)
                {
                    Console.Write(uoc+" ");
                }
                uoc++;
            }
        }
        public static void inSoNgayCuaThang()
        {
            Console.WriteLine("Nhap Thang:  ");
            int thang = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Nam:  ");
            int nam = Int32.Parse(Console.ReadLine());

            switch(thang){
                case 1: 
                case 3:               
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Co 31 ngay!!");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Co 30 ngay!!");
                    break;
                case 2:
                    if (nam % 400 == 0|| nam % 4 == 0 && nam % 100 != 0)
                    {
                        Console.WriteLine("Thang co 28 ngay");
                    }
                    else
                    {
                        Console.WriteLine("Thang co 29 ngay");
                    }
                    break;
                default:
                    //Console.WriteLine("")
                    break;
            }
        }
         static void Main(string[] args)
        {
            //timSoLonNhat();
            // inRaTongnSo();        
            //inRaChuoiNhiPhan();
            printUoc();

            
        }
    }
}
