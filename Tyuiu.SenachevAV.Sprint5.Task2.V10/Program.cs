using Tyuiu.SenachevAV.Sprint5.Task2.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();

        int[,] array = new int[3, 3];
        int row = array.GetUpperBound(0) + 1;
        int col = array.Length / row;

        Console.Title = "Спринт #5 | Выполнил: Сеначев А.В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУБ 24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,заполненный         *");
        Console.WriteLine("* значениями с клавиатуры.                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("Введите " + i + "," + j + " элемент массива:");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Массив:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(array);
        Console.WriteLine("Файл: " + res);
        Console.ReadLine();
    }
}