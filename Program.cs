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
    }
  }  
}
