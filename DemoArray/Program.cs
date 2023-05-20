using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tu:");
            int sopt = int.Parse(Console.ReadLine());

            int[] songuyen = new int[sopt];
            //Nhập các phần tử của mảng
            for(int i = 0; i < songuyen.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i+1}");
                songuyen[i] = int.Parse(Console.ReadLine());
            }

            int tong = 0;
            foreach(int phanTu in songuyen)
            {
                tong  = tong + phanTu;
            }
            double tbc = tong *1.0 / songuyen.Length;
            Console.WriteLine("TBC = " +  tbc);

            Console.WriteLine("lap phuong cac phan tu");
            foreach (int phanTu in songuyen)
            {
                Console.WriteLine(Math.Pow(phanTu,3));
            }

            Console.ReadLine();
        }
    }
}
