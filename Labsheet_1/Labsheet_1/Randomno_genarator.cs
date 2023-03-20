using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    public class Randomno_genarator
    {
        
        public int[] Rano_genarator() {
            //declaring userinput method for array size
            Console.WriteLine("Enter the array Size:");
            int size = int.Parse(Console.ReadLine());

            //declaring an array
            int[] array = new int[size];

            //declaring new object in random class
            Random random = new Random();


            //declare a for loop for genarate random nubers
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                
            }
            //sorting the array
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\nIndex:" + i + " " + array[i]);
            }
           return array;
        }
       
       

        
    }
}
