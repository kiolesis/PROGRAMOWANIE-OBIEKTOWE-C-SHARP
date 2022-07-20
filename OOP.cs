using System;
using System.Threading;

namespace Consoleapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programowanie obiektowe
            // Object Oriented Programming (OOP)

            // - Dziedziczenie
            // - Polimorfizm
            // - Abstrakcja
            // - Hermetyzacja












            /* ŹRÓDŁO DEFINICJI: WIKIPEDIA
            
            1. Abstrakcja
            Każdy obiekt w systemie służy jako model abstrakcyjnego „wykonawcy”,
            który może wykonywać pracę, opisywać i zmieniać swój stan oraz komunikować
            się z innymi obiektami w systemie bez ujawniania, w jaki sposób zaimplementowano
            dane cechy. Procesy, funkcje lub metody mogą być również abstrahowane, a kiedy
            tak się dzieje, konieczne są rozmaite techniki rozszerzania abstrakcji.

            2. Hermetyzacja
            Czyli ukrywanie implementacji, enkapsulacja. Zapewnia, że obiekt nie może zmieniać
            stanu wewnętrznego innych obiektów w nieoczekiwany sposób. Tylko własne metody
            obiektu są uprawnione do zmiany jego stanu. Każdy typ obiektu prezentuje innym
            obiektom swój interfejs, który określa dopuszczalne metody współpracy. Pewne
            języki osłabiają to założenie, dopuszczając pewien poziom bezpośredniego
            (kontrolowanego) dostępu do „wnętrzności” obiektu. Ograniczają w ten sposób
            poziom abstrakcji. Przykładowo w niektórych kompilatorach języka C++ istnieje
            możliwość tymczasowego wyłączenia mechanizmu enkapsulacji; otwiera to dostęp
            do wszystkich pól i metod prywatnych, ułatwiając programistom pracę nad pośrednimi
            etapami tworzenia kodu i znajdowaniem błędów.

            3. Polimorfizm
            Referencje i kolekcje obiektów mogą dotyczyć obiektów różnego typu, a wywołanie
            metody dla referencji spowoduje zachowanie odpowiednie dla pełnego typu obiektu
            wywoływanego. Jeśli dzieje się to w czasie działania programu, to nazywa się to
            późnym wiązaniem lub wiązaniem dynamicznym. Niektóre języki udostępniają bardziej
            statyczne (w trakcie kompilacji) rozwiązania polimorfizmu – na przykład szablony
            i przeciążanie operatorów w C++.

            4. Dziedziczenie
            Porządkuje i wspomaga polimorfizm i enkapsulację dzięki umożliwieniu definiowania
            i tworzenia specjalizowanych obiektów na podstawie bardziej ogólnych. Dla obiektów
            specjalizowanych nie trzeba redefiniować całej funkcjonalności, lecz tylko tę,
            której nie ma obiekt ogólniejszy. W typowym przypadku powstają grupy obiektów
            zwane klasami, oraz grupy klas zwane drzewami. Odzwierciedlają one wspólne cechy
            obiektów.

            ŹRÓDŁO DEFINICJI: WIKIPEDIA








            */

            Car car = new Car("BMW");
            car.Cost = 8000;
            car.Description = "Niezawodny i szybki samochód!";
            car.Ride(5000);

            car.Stop();

            Console.WriteLine("Koniec gry!");

        }
    }

    public class Car
    {
        private string _brand;

        public int Cost { get; set; }
        public string Description { get; set; }

        public Car(string brand)
        {
            _brand = brand;
        }

        public void Ride(int time)
        {
            Console.WriteLine($"Samochód marki {_brand} w trasie!" +
                "\nPrzejażdzka będzie trwała " + time / 1000 + "sekund.");
            Thread.Sleep(time);
        }

        public void Stop()
        {
            Console.WriteLine("Samochód się zatrzymał!");
        }
    }
}
