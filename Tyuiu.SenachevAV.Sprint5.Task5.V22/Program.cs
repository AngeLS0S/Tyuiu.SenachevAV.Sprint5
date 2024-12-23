using Tyuiu.SenachevAV.Sprint5.Task5.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

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

        string path = $@"C:\DataSprint5\InPutDataFileTask5V22.txt";

        Console.WriteLine($"Данные находятся в файле: {path}");

        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("******************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine($"Минимальное целое число в файле: {res}");
        Console.ReadKey();
    }
}