using Tyuiu.CherkashinMM.Sprint2.Task7.V3.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task7.V3.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(true, ds.CheckDotInShadedArea(0.8, 0.2));
   } 
} 
