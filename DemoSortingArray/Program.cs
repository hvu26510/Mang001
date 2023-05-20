using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSortingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //int[] intArray = { 1, 5, 9, 4, 6 };

            //Console.WriteLine("Mang truoc sx:");
            //foreach (int i in intArray)
            //{
            //    Console.Write(i + "  ");
            //}

            ////Sắp xếp tăng dần
            //Array.Sort(intArray);

            //Console.WriteLine();
            //Console.WriteLine("Mang sau sx:");
            //foreach (int i in intArray)
            //{
            //    Console.Write(i+ "  ");
            //}
            ////Đảo ngược mảng
            //Array.Reverse(intArray);

            //Console.WriteLine();
            //Console.WriteLine("Mang dao nguoc:");
            //foreach (int i in intArray)
            //{
            //    Console.Write(i + "  ");
            //}
            //Console.ReadLine();
            #endregion

            Console.OutputEncoding = Encoding.UTF8;

            string[] str = { "Bách", "Anh", "Hiền", "Đạt", "Phú" };

            Array.Sort(str);

            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }

            Console.ReadKey();

        }
    }
}
