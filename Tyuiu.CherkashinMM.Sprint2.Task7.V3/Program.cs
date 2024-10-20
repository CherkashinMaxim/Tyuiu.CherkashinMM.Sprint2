using System;
using Tyuiu.CherkashinMM.Sprint2.Task7.V3.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task7.V3; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                            *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #3                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные        *");
        Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y                   *");
        Console.WriteLine("* в заштрихованной области.                                            *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите переменную Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(ds.CheckDotInShadedArea(x, y)); 
    } 
} 
