using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1,5,9,4,6 } ;

            //for(int i =1; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            int tong = 0;
            foreach(int phantu in intArray)
            {
                if(phantu %2 != 0)
                {
                    tong = tong + phantu;
                }
            }
            Console.WriteLine(tong);
            Console.ReadLine();


        }
    }
}
