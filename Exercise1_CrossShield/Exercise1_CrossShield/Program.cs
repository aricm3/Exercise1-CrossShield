using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_CrossShield
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop for generating numbers 1-100
            for(int i = 1; i < 101; i++)
            {
                //Checks if number is a multiple of both 2 and 7
                if (i % 2 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("CrossShield");
                }
                //If not a multiple of both 2 and 7, checks if it is a multiple of only 2
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Cross");
                }
                //If not a multiple of both 2 and 7, checks if it is a multiple of only 7
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Shield");
                }
                //If not a multiple of 2 or 7, prints out the number
                else
                {
                    Console.WriteLine(i);
                }
            }
            //Keeps console open until any key is pressed
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
