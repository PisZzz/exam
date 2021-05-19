using System;
using System.IO;
using System.Linq;

namespace exam
{
    class MagazineUtil
    {

        private static Magazine[] Shop;
        private static string Path = "..\\..\\..\\Shop.txt";

        public static void Sort()
        {
            if (Shop == null)
            {
                return;
            }

            Shop.AsQueryable()
                .OrderBy(each => each.Price)
                .ThenBy(each => each.Name)
                .ToArray();
        }

        public static void SaveFile()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
                File.Create(Path).Close();
            }

            foreach (Magazine each in Shop)
            {
                File.AppendAllText(Path, each.ToString() + "\n");
            }
        }

        public static void Fill(int length)
        {
            Shop = new Magazine[length];

            for (int i = 0; i < length; ++i)
            {
                Magazine magazine = new Magazine();

                Console.Write(string.Format("[{0}] | Введите название журнала: ", i));
                magazine.Name = Console.ReadLine();

                Console.Write(string.Format("[{0}] | Введите имя издателя: ", i));
                magazine.Publisher = Console.ReadLine();

                while (true)
                {
                    decimal price;

                    Console.Write(string.Format("[{0}] | Введите цену: ", i));
                    if (decimal.TryParse(Console.ReadLine(), out price))
                    {
                        magazine.Price = price;
                        break;
                    }
                }

                while (true)
                {
                    int issn;

                    Console.Write(string.Format("[{0}] | Введите ISSN: ", i));
                    if (int.TryParse(Console.ReadLine(), out issn))
                    {
                        magazine.Issn = issn;
                        break;
                    }
                }

                Shop[i] = magazine;
            }
        }

        public static void Output()
        {
            foreach (Magazine each in Shop)
            {
                Console.WriteLine(each.ToString());
            }
        }

    }
}