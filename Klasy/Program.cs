using System;
using System.Collections.Generic;
using System.IO;

namespace licznik_punktow_do_tysiaca_consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("naciśnij enter aby rozpocząć");
      Klasy.TryParseCS tryParseCS = new Klasy.TryParseCS();
      Klasy.Licznik licznik = new Klasy.Licznik();

      for (int i = 1; i < 1000; i++)
      {
        Console.WriteLine("podaj {0} wynik (liczba a, liczba b)", i);

        if (tryParseCS.Parsujaca() == true)
        {
          Saver();
        }
        else
        {
          Console.WriteLine("nie możesz podawać znaków innych niż liczby oraz ', '");
          i--;
        }
      }
      Console.ReadLine();
    }
    public static void CheckDir()
    {
      string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
      if (!Directory.Exists(dirPath))
      {
        Directory.CreateDirectory(dirPath);
      }
    }

    public static void Saver()
    {
      Klasy.Licznik licznik = new Klasy.Licznik();

      for (int j = 0; j < licznik.intTab.Length; j++)
      {
        Console.WriteLine(licznik.tablica[j]);
        CheckDir();
        string date = $"{DateTime.Now}";
        string[] splitedDate = date.Split(":");
        string filePath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca\zapiska {splitedDate[0] + ", " + splitedDate[1]}.txt";


        File.AppendAllText(filePath,licznik.tablica[1]);


      }
    }

  }
}

