using Tyuiu.CherkashinMM.Sprint2.Task3.V14.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task3.V14.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(-25, ds.Calculate(2));
   } 
} 
