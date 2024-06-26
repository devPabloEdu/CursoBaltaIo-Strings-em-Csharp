using System;

namespace STRINGS
{
  class Program
  {
    static void Main(string [] args)
    {

        //interpolação de strings

        var price = 10.2;
        var texto = "o preço do produto é " + price;
       var texto = string.Format("o preço do produto é {0} apenas na promoção", price);
      var texto = $"O preço do produto \n é {price} apenas na promoção";
      Console.WriteLine(texto);
    }
  }  
}
