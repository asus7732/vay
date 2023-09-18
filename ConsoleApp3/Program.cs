using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {

                Console.Clear();
                double one, two;
                string birth;
                try 
                {
                    Console.WriteLine("Введите первое число");
                    one = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    two = double.Parse(Console.ReadLine());
                }
                catch (Exception)  
                {
                    Console.Write("Не удалось переобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберете операцию: '+' '-' '*' '/'");
                birth = (Console.ReadLine());

                Console.Clear();
                switch (birth)
                {
                    case "+":
                        Console.WriteLine(one + two);

                        break;

                    case "-":

                        Console.WriteLine(one - two);

                        break;

                    case "*":
                        Console.WriteLine(one * two);



                        break;

                    case "/":
                        Console.WriteLine(one / two);

                        break;

                    default:
                        Console.WriteLine("Ошибка! Неизвестное действие!");
                        break;



                }

                Console.ReadLine();
            }
                }
            }
            

           


        }
