using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чётное или нечётное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("Чётное");
            }
            else
            {
                Console.WriteLine("Нечётное");
            }
            Console.ReadLine();
        }
    }
}
