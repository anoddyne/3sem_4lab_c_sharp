using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            Console.WriteLine(time.Current);
            char menu = 'y';
            while (menu != 'n')
            {
                Console.WriteLine("Выберите действие: 1 - изменить часы, 2 - изменить минуты, 3 - изменить секунды");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите часы (чтобы вычесть, напишите перед числом знак -): ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(time.ChangeHour(ch));
                        break;
                    case 2:
                        Console.WriteLine("Введите минуты (чтобы вычесть, напишите перед числом знак -): ");
                        int cm = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(time.ChangeMinute(cm));
                        break;
                    case 3:
                        Console.WriteLine("Введите секунды (чтобы вычесть, напишите перед числом знак -): ");
                        int cs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(time.ChangeSecond(cs));
                        break;
                    default:
                        Console.WriteLine("Введите число 1-3! \n");
                        break;
                }
                Console.WriteLine("Продолжить? (y/n)");
                menu = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
