using System;
using System.Collections.Generic;

namespace Exception_final2
{
    internal class Sort
    {
        string[] array;

            public Sort(string[] array)
            {
                this.array = array;
            }

            public delegate void SortDelegate(int numb);
            public event SortDelegate ChoosenEvent;
            protected void Choosen(int numb)
            {
                ChoosenEvent?.Invoke(numb);
            }
            public void Choose()
            {
                Console.WriteLine("\nСортировка фамилий: \n\t 1 - по возрастанию (от А до Я) \n\t 2 - по убыванию (от Я до А)");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number != 1 && number != 2) throw new FormatException();
                Choosen(number);
            }
            public void SortAZ()
            {
                Console.WriteLine("по возрастанию:");
                Array.Sort(array);
                foreach (string str in array)
                    Console.WriteLine(str);
            }
            public void SortZA()
            {
                Console.WriteLine("по убыванию:");
                Array.Sort(array);
                Array.Reverse(array);
                foreach (string str in array)
                    Console.WriteLine(str);
            }
     }
}
