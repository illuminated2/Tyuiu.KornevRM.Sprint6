using Tyuiu.KornevRM.Sprint6.Task0.V23.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.223;
            Assert.AreEqual(wait, res);

        }
    }
}