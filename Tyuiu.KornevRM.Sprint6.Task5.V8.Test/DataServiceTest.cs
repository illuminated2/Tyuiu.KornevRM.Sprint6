using Tyuiu.KornevRM.Sprint6.Task5.V8.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\iLLum\source\repos\Tyuiu.KornevRM.Sprint6\Tyuiu.KornevRM.Sprint6.Task5.V8\bin\DebugInPutFileTask5V8.txt";
            double[] wait = { -13, -19, -9, 82, -9, 71, -0, 11, -17, 36, -12, -12, 35 };
            double[] res = ds.LoadFromDataFile(path);
        }
    }
}