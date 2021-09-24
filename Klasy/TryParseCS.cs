using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VisioForge.Shared.MediaFoundation.OPM;

namespace licznik_punktow_do_tysiaca_consola.Klasy
{
  public class TryParseCS
  {
    Licznik licznik = new Licznik();

    public bool Parsujaca()
    {
      licznik = new Licznik();
      for (int i = 0; i < licznik.tablica.Length; i++)
      {
        if (int.TryParse(licznik.tablica[i], out licznik.intTab[i]))
        {
          return true;
        }       
      }
      return false;
    }


    public void Saver()
    {
      for (int j = 0; j < licznik.tablica.Length; j++)
      {
        Console.WriteLine(licznik.tablica[j]);
        CheckDir();
        string date = $"{DateTime.Now}";
        string[] splitedDate = date.Split(":");
        string filePath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca\zapiska {splitedDate[0] + "; " + splitedDate[1]}.txt";
        File.AppendAllText(filePath, licznik.tablica[j] + "\n");
      }
    }


    public void CheckDir()
    {
      string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
      if (!Directory.Exists(dirPath))
      {
        Directory.CreateDirectory(dirPath);
      }
    }


  }
}
