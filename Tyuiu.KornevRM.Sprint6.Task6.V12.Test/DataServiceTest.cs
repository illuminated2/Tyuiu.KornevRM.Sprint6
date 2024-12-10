using System.Diagnostics;
using Tyuiu.KornevRM.Sprint6.Task6.V12.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
       

        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);



        }
    }
}