using Tyuiu.CherkashinMM.Sprint2.Task0.V5.Lib;

namespace Tyuiu.CherkashinMM.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();

            bool[] valid = [false, true, true, true, false, true];
            int x = 105;
            int y = 223;

            CollectionAssert.AreEqual(valid, ds.GetCompareOperations(x,y));
        }
    }
}