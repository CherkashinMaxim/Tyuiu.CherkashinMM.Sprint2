using Tyuiu.CherkashinMM.Sprint2.Task5.V9.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task5.V9; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #9                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную m:"); 
        int m = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную n:"); 
        int n = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        Console.WriteLine(ds.FindDateOfNextDay(m, n));
    } 
} 
