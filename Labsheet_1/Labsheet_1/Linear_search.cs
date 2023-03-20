using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    internal class Linear_search
    {
      
        
        //declaring linear serach method with a parameter
        public int L_search(int[] arr)
        {
            Stopwatch a = new Stopwatch();
            a.Start();
            //declaring the find value as keyvalue and initiate the find value as 50
            int keyvalue = 50;
            
            //declaring a for loop for search the key value in the array
            for (int i = 0; i < arr.Length; i++)
            {
                //declaring if clause to check whether the keyvalue is eqaul to the array value
                if (arr[i] == keyvalue)
                {
                    Console.WriteLine("\nFound keyvalue in index:"+i);
                }
                    
            }
            a.Stop();
            Console.WriteLine("Time Taken:" + a.Elapsed.TotalMilliseconds + "secounds");


            return -1;

        }
        public static void Main(string[] args)
        {
            Randomno_genarator a = new Randomno_genarator();
            
            
            
            Linear_search b = new Linear_search();
            int[] arr = a.Rano_genarator();
            b.L_search(arr);
           
            Binary_search c = new Binary_search();
            int[]  arry = a.Rano_genarator();
            c.B_search(arry);
            

        }
    }
}
