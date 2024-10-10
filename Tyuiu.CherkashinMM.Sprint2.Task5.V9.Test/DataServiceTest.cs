using Tyuiu.CherkashinMM.Sprint2.Task5.V9.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task5.V9.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual("1.12", ds.FindDateOfNextDay(11, 30));
   } 
} 
