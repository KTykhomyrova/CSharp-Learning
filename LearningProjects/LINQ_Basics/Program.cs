using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>
            {
                "To Kill a Mockingbird",
                "Pride and Prejudice",
                "One Hundred Years of Solitude",
                "The Great Gatsby",
                "Crime and Punishment"
            };

            // 1. Книги > 12 символов
            var LongerThanTwelve = books.Where(x => x.Length > 12).ToList();
            
            if(LongerThanTwelve == null)
                Console.WriteLine("There are no one book eich name longer than 12");
            else
            {
                Console.WriteLine("Books wich name longer than 12:");
                foreach (var item in LongerThanTwelve)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"________________________________________________________________________");
            // 2. Сортировка
            var OrderByAlfabet = books.OrderBy(x => x).ToList();
            if (OrderByAlfabet == null)
                Console.WriteLine("No items");
            else 
            {
                Console.WriteLine("Sorted books:");

                foreach (var item in OrderByAlfabet)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"________________________________________________________________________");
            // 3. В верхнем регистре
            var LettersUpp = books.Select(x => x.ToUpper()).ToList();
            if (LettersUpp == null)
                Console.WriteLine("No items");
            else
            {
                Console.WriteLine("Big letters:");

                foreach (var item in LettersUpp)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"________________________________________________________________________");
            // 4. Первая на "P"
            var firstPBook = books.FirstOrDefault(x => x.StartsWith("P"));
            if (firstPBook == null)
                Console.WriteLine("There any books that started on 'P'");
            else
                Console.WriteLine($"The first book wich started on 'P' is {firstPBook}");
            Console.WriteLine($"________________________________________________________________________");
            // 5. Количество символов
            int AllLength = books.Sum(x => x.Length);
            if (AllLength == 0 || AllLength == null)
                Console.WriteLine("No items");
            else
                Console.WriteLine($"There are {AllLength} sybols");
            Console.WriteLine($"________________________________________________________________________");
            Console.ReadKey();
        }
    }
}
