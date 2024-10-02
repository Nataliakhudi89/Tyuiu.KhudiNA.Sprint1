using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhudiNA.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KhudiNA.Sprint1.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 1 | Выполнила: Худи Н. А. | ИСТНб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт1                                                                   *");
            Console.WriteLine("* Тема: Арифметические операторы                                           *");
            Console.WriteLine("*Задание #2                                                                *");
            Console.WriteLine("*Вариант #19                                                               *");
            Console.WriteLine("* Выполнила: Худи Наталья Александровна  |  ИСТНб-24-1                     *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.               *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int x;
            Console.WriteLine("Введите расстояние в километрах");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Расстояние в милях = " + ds.ConvertInchToKm(x));
            Console.ReadLine();
        }
    }
}