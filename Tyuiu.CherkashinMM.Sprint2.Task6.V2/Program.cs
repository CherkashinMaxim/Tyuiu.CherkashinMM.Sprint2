using Tyuiu.CherkashinMM.Sprint2.Task6.V2.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task6.V2; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                            *");
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #2                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* По данному месяцу, определите в какую пору года попадает             *");
        Console.WriteLine("* этот месяц (Зима, Лето, Весна, Осень).                               *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите номер месяца:"); 
        int x = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(ds.FindMonthSeason(x)); 
    } 
} 
