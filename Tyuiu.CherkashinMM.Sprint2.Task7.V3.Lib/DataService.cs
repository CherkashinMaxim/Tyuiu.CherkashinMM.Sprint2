using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task7.V3.Lib;

public class DataService : ISprint2Task7V3
{
    public bool CheckDotInShadedArea(double x, double y)
    {
        bool y1 = ((x * x) + Math.Pow(y - 1, 2)) <= 1;
        bool y2 = y <= (1 - x*x);

        return y1 && y2 ? true : false;
    }
} 
