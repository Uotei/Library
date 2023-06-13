using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library
{
    class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1. Wypożycz Książkę");
            Console.WriteLine("2. Oddaj Książkę");
            Console.WriteLine("3. Dodaj Książkę");
            Console.WriteLine("4. Usuń książkę");
            Console.WriteLine("5. Edytuj książkę");
            Console.WriteLine("6. Sprawdź dostępne książki:");

            while (true)
            {
                var input = Console.ReadKey(true);
                
                switch (input.Key)
                {
                    case ConsoleKey.D1:

                        break;
                    case ConsoleKey.D2:

                        break;
                    case ConsoleKey.D3:
                        Menu.AddBookMenu();
                        break;
                    case ConsoleKey.D4:

                        break;
                    case ConsoleKey.D5:

                        break;
                    case ConsoleKey.D6:

                        break;
                    case ConsoleKey.Enter:
                        MainMenu();
                        break;
                }
            }
        }
        public static void AddBookMenu()
        {
            Console.WriteLine("Podaj ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź Tytuł:");
            string title = Console.ReadLine();
            Console.WriteLine("Wprowadź Autora");
            string author = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania:");
            string releaseDate = Console.ReadLine();
            Console.WriteLine("Wprowadź wydawcę:");
            string publisher = Console.ReadLine();
            Console.WriteLine("Podaj numer ISBN:");
            string isbn = Console.ReadLine();
            Console.WriteLine("Podaj gatunek książki:");
            string genre = Console.ReadLine();
            Console.WriteLine("Podaj ilość sztuk");
            int stock = int.Parse(Console.ReadLine());
            Library.AddBook(id, title, author, releaseDate, publisher, isbn, genre, stock);
            Console.WriteLine("Naciśnij enter aby wrócić do menu głównego");
        }
    }
}
