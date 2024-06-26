using System;

namespace STRINGS
{
  class Program
  {
    static void Main(string [] args)
    {
        var id = Guid.NewGuid();
        id.ToString(); //transformando o id em uma string

        id = new Guid("00000000000000000000000000000000 ");
        Console.WriteLine(id); //vai imprimir um hash

        //interpolação de strings

        var price = 10.2;
        //var texto = "o preço do produto é " + price;
       //var texto = string.Format("o preço do produto é {0} apenas na promoção", price);
      //var texto = $"O preço do produto \n é {price} apenas na promoção";
      //Console.WriteLine(texto);

        var texto = "este texto é um teste";
        //Console.WriteLine(texto.CompareTo("testando")); compara as palavras e retorna um valor
        Console.WriteLine(texto.Contains("teste")); //compara e ve se a string passada no parametro existe na string original, retorna um boolean
    }
  }  
}
