using Tyuiu.CherkashinMM.Sprint2.Task4.V30.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task4.V30.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(49, ds.Calculate(2, 2));
   } 
} 
