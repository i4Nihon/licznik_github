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





  }
}
