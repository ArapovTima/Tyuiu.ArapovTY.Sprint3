using Tyuiu.ArapovTY.Sprint3.Task3.V15.Lib;
namespace Tyuiu.ArapovTY.Sprint3.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Арапов Т. Я. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Арапов Тимофей Яковлевич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв m,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "Irmmse mg sermmmrt";
            char chr = 'g';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый результат = " + chr);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество символов = " + ds.GetMinCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
