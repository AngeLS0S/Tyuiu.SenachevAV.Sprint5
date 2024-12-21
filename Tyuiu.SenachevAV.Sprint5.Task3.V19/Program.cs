using Tyuiu.SenachevAV.Sprint5.Task3.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        int x = 3;

        Console.Title = "Спринт #5 | Выполнил: Сеначев А.В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУБ 24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
        Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль.                 *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X = " + x);


        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");
    }
}