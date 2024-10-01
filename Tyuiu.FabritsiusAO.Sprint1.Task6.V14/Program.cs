using Tyuiu.FabritsiusAO.Sprint1.Task6.V14.Lib;
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класса String                                  *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("* Проверить, что строка составлена только из строчных русских букв.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("Введите текст:");
        string str;
        str = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool a = ds.CheckLowerCaseRusLetters(str);
        if (a == true)
        {
            Console.WriteLine("Строка составлена только из строчных русских букв");
        }
        else
        {
            Console.WriteLine("Строка содержит не только строчные русские буквы");
        }
        Console.ReadLine();
    }
}