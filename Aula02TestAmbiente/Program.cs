using System;
using Aula02TestAmbiente.Entities;

namespace Aula02TestAmbiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Autor autor = new Autor(300, "Joao");

            Livro livro = new Livro(200, "Auto da Compadecida", autor);

            autor.Id = 2;
            Console.WriteLine(autor.Id);
            
        }
    }
}


