using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    public class Binary_search
    {   
        public int B_search(int[] arr) {
            //declaring parameters mid,first and last and keyvalue
            int mid;
            int first = 0;
            int last = arr.Length - 1;
            int keyvalue = 50;


            Stopwatch sw = new Stopwatch(); 
            sw.Start();
            if (first >= last)
            {
                return -1;
            }
            while (first < last)
            {
                mid = first + (last - first) / 2;
                if (arr[mid] == keyvalue)
                {
                    
                    Console.WriteLine("\nValue found:" + mid);
                    return mid;
                }
                else if (arr[mid] < keyvalue)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }

            }
           
            Console.WriteLine("\nValue Not Found");
            sw.Stop();
            Console.WriteLine("Time Taken:" + sw.Elapsed.TotalMilliseconds + "secounds");


            return -1;

        }
    }
}
