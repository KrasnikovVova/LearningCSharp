using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace заново
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[20];
            for (int i = 0; i < 20; i++) 
            {
                nums[i] = rnd.Next(-100, 101);
            }
            for (int i = 0; i < 20; i++) 
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.ReadLine();
        }
    }
}

