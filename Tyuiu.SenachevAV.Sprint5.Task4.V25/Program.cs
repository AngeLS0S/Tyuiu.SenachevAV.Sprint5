using Tyuiu.SenachevAV.Sprint5.Task4.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Title = "Спринт #5 | Выполнил: Сеначев А.В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУБ 24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string A_Path = Console.ReadLine();

        DataService DS = new DataService();
        var T = DS.LoadFromDataFile(A_Path);

        Console.WriteLine("РЕЗУЛЬТАТ: " + T);
        Console.ReadKey();
    }
}