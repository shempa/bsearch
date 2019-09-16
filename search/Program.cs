using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    class Program
    {
        static int res;
        static void Main(string[] args)
        {           
            Console.WriteLine("Ведите целочисленное значение х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов одномерного массива");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите отсортированный по убыванию массив целых чисел");           
            int[] mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Индекс первого элемента массива, строго меньшего X");
            var res = bsearch(mas, x);
            Console.WriteLine(res);
            Console.ReadKey();        
        }

        static int bsearch(int[] mas, int x )
        {            
            for (int i = 0; i<mas.Length;i++)
            {                
                if (mas[i] < x)
                {
                    res=i;                   
                    break;                                     
                }               
            }
            return res;
        }
    }
}
