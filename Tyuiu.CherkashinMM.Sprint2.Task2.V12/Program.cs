using Tyuiu.CherkashinMM.Sprint2.Task2.V12.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task2.V12; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #12                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с          *");
        Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y         *");
        Console.WriteLine("* в заштрихованной области.                                            *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        int x = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Введите переменную Y:"); 
        int y = Convert.ToInt32(Console.ReadLine()); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(ds.CheckDotInShadedArea(x, y)); 
    } 
} 
