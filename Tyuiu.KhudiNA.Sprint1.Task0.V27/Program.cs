﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhudiNA.Sprint1.Task0.V27.Lib;

//Задание 
//Написать программу, которая вычислить выражение 5*2 + 4*3 и печатает результат на экране

namespace Tyuiu.KhudiNA.Sprint1.Task27.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 1 | Выполнила: Худи Н. А. | ИСТНб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         ");
            Console.WriteLine("* Задание #0                                                               ");
            Console.WriteLine("* Вариант #0                                                               ");
            Console.WriteLine("* Выполнила: Худи Наталья Александровна | ИСТНб-24-1                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 5*2 + 4*3                ");
            Console.WriteLine("* и печатает результат на экране.                                          ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 5*2 + 4*3                                                                ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.KhudiNA.Sprint1.Task0.V0.Lib;
            //в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
