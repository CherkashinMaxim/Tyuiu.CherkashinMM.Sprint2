using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task4.V30.Lib;

public class DataService : ISprint2Task4V30
{
    public double Calculate(double x, double y)
    {
        return x * 2 > y ? Math.Round(Math.Pow(6 + (4 / (x * x)), y), 3) : Math.Round(y + (2 / (x * x)), 3);
    }
} 
