using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int length;
            while (true)
            {
                Console.Write("Введите размер массива: ");

                if (int.TryParse(Console.ReadLine(), out length))
                {
                    break;
                }
            }

            Console.WriteLine("\tУспешно, заполнение массива...");
            MagazineUtil.Fill(length);

            Console.WriteLine("\tУспешно, вывод массива...");
            MagazineUtil.Output();

            Console.WriteLine("\tУспешно, сортировка массива...");
            MagazineUtil.Sort();

            Console.WriteLine("\tУспешно, вывод массива...");
            MagazineUtil.Output();

            Console.WriteLine("\tУспешно. Сохранение в файл...");
            MagazineUtil.SaveFile();
        }
    }
}