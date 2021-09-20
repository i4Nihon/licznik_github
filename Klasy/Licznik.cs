using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace licznik_punktow_do_tysiaca_consola.Klasy
{
  class Licznik
  {
    public string[] tablica;
    public int[] intTab;

    public Licznik()
    {
      tablica = Console.ReadLine().Split(", ");
      intTab = new int[tablica.Length];

    }
    
    



  }
}
