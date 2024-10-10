using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task3.V14.Lib;

public class DataService : ISprint2Task3V14
{
    public double Calculate(double x)
    {
        if (x > 1)
        {
            return x - Math.Pow((x + 1) / (x - 1), 3);
        }
        else if (x == 0)
        {
            return (3 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 3)) + 10) / (4 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 4)) + 12);
        } 
        else if ((x > - 18) && (x < 2))
        {
            return Math.Pow(1 + 1 / (x * x), x);
        }
        else if (x < -18)
        {
            return x + 10 * x - (1 / x);
        }
        return 0;
    }
} 
