/*Biblioteka
* pola
- lista wypożyczonych książek
- lista książek (na stanie)
-lista użytkowników
* metody
- wypisz listę wszystkich książek
- wypisz listę wypożyczonych książek i ich użytkowników
- dodaj książkę
- usuń książkę
- edytuj książkę
- szukaj (tytuł, autor, gatunek)

Książka
- ID
- tytuł
- autor
- rok wydania
- wydawca
- numer ISBN
- gatunek
- liczba dostępnych egzemplarzy

Pożyczający
- imię i nazwisko
- ID

WypożyczonaKsiążka
- data wypożyczenia
- data zwrotu
- ID ksiązki
- ID użytkownika*/
using System.Linq;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library();
            Menu.MainMenu();
        }
    }   
}
