using Tyuiu.SenachevAV.Sprint5.Task7.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Сеначев А.В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУБ 24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";
        string res = File.ReadAllText(path);
        Console.WriteLine(res);
        Console.WriteLine("Файл находится тут: " + path);

        Console.WriteLine("****************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                   *");
        Console.WriteLine("****************************************************************");

        string outputFilePath = ds.LoadDataAndSave(path);
        Console.WriteLine($"Файл сохранен: {outputFilePath}");
        Console.ReadKey();
    }
}