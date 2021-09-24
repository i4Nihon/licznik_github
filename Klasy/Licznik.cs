using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace licznik_punktow_do_tysiaca_consola.Klasy
{
  public class Licznik
  {
    public string[] tablica;
    public int[] intTab;

    public Licznik()
    {
      tablica = Console.ReadLine().Split(", ");
      intTab = new int[tablica.Length];
    }
    
    public void podliczająca()
    {
      string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
      string filePath = $@"{Directory.GetFiles(dirPath, "*.txt").Select(f => new FileInfo(f)).
                                    OrderByDescending(f => f.CreationTime)}";

    }



  }
}
