using Tyuiu.SenachevAV.Sprint5.Task3.V19.Lib;

namespace Tyuiu.SenachevAV.Sprint5.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Cloud Star\source\repos\Tyuiu.SenachevAV.Sprint5\Tyuiu.SenachevAV.Sprint5.Task3.V19\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}