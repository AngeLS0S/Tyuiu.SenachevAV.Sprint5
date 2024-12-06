using Tyuiu.SenachevAV.Sprint5.Task0.V13.Lib;

namespace Tyuiu.SenachevAV.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {

            string path = @"C:\Users\Cloud Star\source\repos\Tyuiu.SenachevAV.Sprint5\Tyuiu.SenachevAV.Sprint5.Task0.V13\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}