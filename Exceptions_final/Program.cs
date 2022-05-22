using System;
using System.Collections.Generic;
using System.IO;

namespace Exceptions_final
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exception> exceptions = new List<Exception>();
            exceptions.Add(new MyOwnException("Что-то пошло не по плану и мы уже выясняем причину. Вам придется немного подождать."));
            exceptions.Add(new ArgumentException());
            exceptions.Add(new DivideByZeroException());
            exceptions.Add(new FileNotFoundException());
            exceptions.Add(new FormatException());
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e) when (e is MyException)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e) when (e is ArgumentException)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e) when (e is DivideByZeroException)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e) when (e is FileNotFoundException)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e) when (e is FormatException)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Enter, чтобы продолжить");
                continue;
            }
        }
    }
}
