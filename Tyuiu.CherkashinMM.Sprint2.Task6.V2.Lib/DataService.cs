using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task6.V2.Lib;

public class DataService : ISprint2Task6V2
{ 
    public string FindMonthSeason(int value)
    {
        switch (value)
        {
            case 1:
                return "çèìà";
            case 2:
                return "çèìà";
            case 3:
                return "âåñíà";
            case 4:
                return "âåñíà";
            case 5:
                return "âåñíà";
            case 6:
                return "ëåòî";
            case 7:
                return "ëåòî";
            case 8:
                return "ëåòî";
            case 9:
                return "îñåíü";
            case 10:
                return "îñåíü";
            case 11:
                return "îñåíü";
            case 12:
                return "çèìà";
            default:
                return "Íåâåðíîå çíà÷åíèå";
        }
    }
} 
