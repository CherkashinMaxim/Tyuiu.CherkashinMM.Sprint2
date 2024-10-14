using Tyuiu.CherkashinMM.Sprint2.Task6.V2.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint2.Task6.V2.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual("Зима", ds.FindMonthSeason(1));
   } 
} 
