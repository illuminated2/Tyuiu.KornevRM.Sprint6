using Tyuiu.KornevRM.Sprint6.Task6.V11.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V11.txt";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, "dwCKLDzrngpZmJ JmSRt gRwqYNbPcwgQilXS HjOGYcyzHD CmqxgaKlPLMCQBJC");
        }
    }
}