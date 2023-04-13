using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool prost = true;
            Console.WriteLine("Введите простое число ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i*i <= number ; i++)
            {
                if (number % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if(prost)
            {
                Console.WriteLine("Число простое ");
            }
            else
            {
                Console.WriteLine("Число не простое ");
            }
            Console.ReadKey();
        }
    }
}
