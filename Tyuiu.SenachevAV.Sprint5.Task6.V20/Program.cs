using Tyuiu.SenachevAV.Sprint5.Task6.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Сеначев А.В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУБ 24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";

        Console.WriteLine("данные находятся в файле " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
    }
}