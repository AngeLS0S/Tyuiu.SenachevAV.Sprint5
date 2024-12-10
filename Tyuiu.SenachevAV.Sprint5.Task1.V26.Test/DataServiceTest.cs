using Tyuiu.SenachevAV.Sprint5.Task1.V26.Lib;

namespace Tyuiu.SenachevAV.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Cloud Star\source\repos\Tyuiu.SenachevAV.Sprint5\Tyuiu.SenachevAV.Sprint5.Task1.V26\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}