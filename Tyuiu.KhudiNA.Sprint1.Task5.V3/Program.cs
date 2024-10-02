using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhudiNA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.KhudiNA.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 1 | Выполнила: Худи Н. А. | ИСТНб-24-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert              *");
            Console.WriteLine("* Задание #5                                              *");
            Console.WriteLine("* Вариант #3                                              *");
            Console.WriteLine("* Выполнила: Худи Наталья Александровна  |  ИСТНб-24-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая находит частное между Х       ");
            Console.WriteLine("*и его корнем. Ответ привести к целому с помощью класса   *");
            Console.WriteLine("*Convert.                                                 *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите значение K ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            int res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}