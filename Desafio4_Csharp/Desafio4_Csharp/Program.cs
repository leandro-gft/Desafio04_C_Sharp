using System;
using System.Collections.Generic;

namespace Desafio4_Csharp
{
    class Program
    {
		static void Main(string[] args)
		{
			Livro l1 = new Livro("Harry Potter", 40.0, 50, "J. K. Rownling", "fantasia", 300);
			Livro l2 = new Livro("O Senhor dos Aneis", 60.0, 30, "J. R. R. Tolkien", "fantasia", 500);
			Livro l3 = new Livro("Java POO", 20.0, 50, "GFT", "educativo", 500);

			Videogame ps4 = new Videogame("PS4", 1800, 100, "Sony", "Slim", false);
			Videogame ps4Usado = new Videogame("PS4", 1000, 7, "Sony", "Slim", true);
			Videogame xbox = new Videogame("XBOX", 1500, 500, "Microsoft", "One", false);

			List<Livro> livros = new List<Livro>();
			livros.Add(l1);
			livros.Add(l2);
			livros.Add(l3);
			
			List<Videogame> games = new List<Videogame>();
			games.Add(ps4);
			games.Add(ps4Usado);
			games.Add(xbox);

			Loja americanas = new Loja("Americanas", "12345678", livros, games);

			l1.calculaImposto();
			l2.calculaImposto();
			l3.calculaImposto();

			ps4.calculaImposto();
			ps4Usado.calculaImposto();
			xbox.calculaImposto();
			Console.WriteLine("---------------------------------------------------------------------------");

			americanas.listaLivros();
			americanas.listaVideogames();
			americanas.calculaPatrimonio();
			Console.ReadKey();
        }
    }
}
