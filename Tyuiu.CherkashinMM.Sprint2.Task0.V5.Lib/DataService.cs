using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CherkashinMM.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = [x == y, x != y, x < y, x > y, x <= y, x >= y];
            return result;
        }
    }
}
