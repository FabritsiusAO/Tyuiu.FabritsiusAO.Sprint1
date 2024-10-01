using Tyuiu.FabritsiusAO.Sprint1.Task4.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема:                                                                   *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.Ответ округлите *");
        Console.WriteLine("* до 3 знаков после запятой.                                              *");
        Console.WriteLine("* Формула:                                                                *");
        Console.WriteLine("*       1                                                                 *");
        Console.WriteLine("*   ---------                                                             *");
        Console.WriteLine("*   (x + 2)^2                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;
        Console.WriteLine("Введите переменную x");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Произведение равно " + ds.Calculate(x));

        Console.ReadLine();
    }
}