using System;

namespace STRINGS
{
  class Program
  {
    static void Main(string [] args)
    {

        var texto = "este texto é um teste";
        Console.WriteLine(texto.CompareTo("testando")); //compara as palavras e retorna um valor
        Console.WriteLine(texto.Contains("teste")); //compara e ve se a string passada no parametro existe na string original, retorna um boolean
       Console.WriteLine(texto.StartsWith("este"));
      Console.WriteLine(texto.Equals("teste"));
    }
  }  
}
