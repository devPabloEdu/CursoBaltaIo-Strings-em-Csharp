using System;

namespace STRINGS
{
  class Program
  {
    static void Main(string [] args)
    {
        var texto = "este texto é um teste";
      Console.WriteLine(texto.IndexOf("é"));
      Console.WriteLine(texto.LastIndexOf("s"));
    }
  }  
}
