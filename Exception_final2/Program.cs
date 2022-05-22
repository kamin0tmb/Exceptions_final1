using System;
using System.Collections.Generic;

namespace Exception_final2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Минаев", "Шарикова", "Иванов", "Любимов", "Каримов" };
            Sort sort = new Sort(array);
            sort.ChoosenEvent += ShowArray;
            try
            {
               sort.Choose();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }

            void ShowArray(int numb)
            {
                switch (numb)
                {
                    case 1: sort.SortAZ(); break;
                    case 2: sort.SortZA(); break;
                }
            }
        }


    }
} 

