using Tyuiu.FabritsiusAO.Sprint1.Task2.V23.Lib;
    internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите число:");
        int minutes = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.ConvertMinutesToSeconds(minutes));
        Console.ReadKey();


    }
}
