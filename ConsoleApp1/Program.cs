using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double one, two;
            string birth;
            Console.WriteLine("Введите первое число");
            one = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            two = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберете операцию: '+' '-' '*' '/'");
            birth = (Console.ReadLine());
            
            if (birth == "+")
            {
                Console.WriteLine(one + two);
            }
            else if (birth == "-")   
            {
                Console.WriteLine(one - two);   
            }
            else if ( birth == "*")
            {
                Console.WriteLine(one * two);
            }
            else if( birth == "/")
            {
                if (one == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(one / two);
            }
            else
            {
                Console.WriteLine("Ошибка! Неизвестное действие!");
            }
            Console.ReadLine(); 

        }

    }
   
    
   
}

