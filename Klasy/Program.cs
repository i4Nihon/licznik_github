
using System;
using System.IO;

namespace licznik_punktow_do_tysiaca_consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("naciśnij enter aby rozpocząć");
      Klasy.TryParseCS tryParseCS = new Klasy.TryParseCS();
      for (int i = 1; i < 1000; i++)
      {
        Console.WriteLine("Naciśnij enter. Następnie podaj {0} wynik (liczba a, liczba b).", i);
        Klasy.Licznik licznik = new Klasy.Licznik();
        bool tryParseTrue = tryParseCS.Parsujaca() == true;
        if (licznik.tablica.Length != 2)
        {
          Console.WriteLine("Musisz podać 2 liczby, (liczba a, liczba b)");
          i--;
        }
        else
        {
          if (tryParseTrue)
          {
            tryParseCS.Saver();
          }
          else
          {
            Console.WriteLine("nie możesz podawać znaków innych niż liczby oraz ',', naciśnij enter aby kontynuować ");
            i--;
          }
        }
      }

      Console.ReadLine();
    }


  }
}

