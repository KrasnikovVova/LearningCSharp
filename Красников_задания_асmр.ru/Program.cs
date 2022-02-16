using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int k = 20;
            int max = -999;
            int min = 999;
            int maxpos = -1;
            int minpos = -1;
            int sum = 0;
            long banana = 1; //ахахахахаххаахах, я гений))))
            int[] nums = new int[k];
            for (int i = 0; i < k; i++)
            {
                nums[i] = rnd.Next(-100, 101);
            }
            void Print_nums()
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            void Print_max_and_min_and_position_lol_это_слишком_длинное_название_для_метода_ну_ладно_пусть_будет_так_оно_мне_не_мешает()
            {
                for (int i = 0; i < k; i++)
                {
                    if (max < nums[i]) { max = nums[i]; maxpos = i + 1; }
                    if (min > nums[i]) { min = nums[i]; minpos = i + 1; }
                }
                Console.WriteLine();
                Console.WriteLine("Максимальное число " + max + " по порядку " + maxpos);
                Console.WriteLine("Минимальное число " + min + " по порядку " + minpos);
            }
            void Print_summa_and_proizvedenie()
            {
                for (int i = 0; i < k; i++)
                {
                    
                    sum = nums[i] + sum;
                    banana = nums[i] * banana;
                    
                }
                Console.Write("Сумма = " + sum + ", а произведение = " + banana);
            }
            void среднее_арифметическое_элементов()
            {
                for (int i = 0; i < k; i++)
                {

                    sum = nums[i] + sum;
                    

                }
                Console.WriteLine();
                Console.Write("среднее арифметическое элементов = " + (double)sum/k);
            }
            Print_nums();

            Print_max_and_min_and_position_lol_это_слишком_длинное_название_для_метода_ну_ладно_пусть_будет_так_оно_мне_не_мешает();

            Print_summa_and_proizvedenie();

            среднее_арифметическое_элементов();

            Console.ReadLine();
        }
    }
}

