using System;
using System.Collections.Generic;
using System.Text;
using VisioForge.Shared.MediaFoundation.OPM;

namespace licznik_punktow_do_tysiaca_consola.Klasy
{
  public class TryParseCS
  {
    public bool Parsujaca()
    {
      Licznik licznik = new Licznik();

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
