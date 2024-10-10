using Tyuiu.CherkashinMM.Sprint2.Task2.V12.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task2.V12.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(false, ds.CheckDotInShadedArea(15, 15));
   } 
} 
