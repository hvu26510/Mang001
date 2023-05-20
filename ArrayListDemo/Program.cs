using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arl1 = new ArrayList();

            int count = 1;
            while (true)
            {
                Console.WriteLine("Nhap vao so nguyen thu " + count);
                Console.WriteLine("Nhap 'q de thoat'");
                string str = Console.ReadLine();
                if(str == "q")
                {
                    break;
                }

                arl1.Add(int.Parse(str));                
            }

            //đếm số chẵn 
            count = 0;

            for(int i = 0; i < arl1.Count; i++)
            {
                int temp = Convert.ToInt32(arl1[i]);
                if(temp % 2 == 0)
                {
                    count++;
                } 
            }

            Console.WriteLine($"Co {count} phan tu chan");

            //xoa so chan

            for (int i = 0; i < arl1.Count; i++)
            {
                int temp = Convert.ToInt32(arl1[i]);
                if (temp % 2 == 0)
                {
                    arl1.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine("Sau khi loai bo cac so chan");
            foreach(int i in arl1) 
            { 
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
