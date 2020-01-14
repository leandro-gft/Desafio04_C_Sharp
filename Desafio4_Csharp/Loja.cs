using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
	public class Loja
	{

		public Loja(String nome, String cnpj, List<Livro> livros, List<Videogame> games)
		{
			this.nome = nome;
			this.cnpj = cnpj;
			this.livros = livros;
			this.games = games;
	}

		private String nome;
		private String cnpj;
		private List<Livro> livros;
		private List<Videogame> games;

		public string Nome { get; set; }
		public string Cnpj { get; set; }
		public List<Livro> Livros { get; set; }
		public List<Videogame> Games { get; set; }

		public void loja()
		{

		}

		public void loja(String nome, String cnpj, List<Livro> livros, List<Videogame> games)
		{

		}
				
		public void listaLivros()
		{
			if (livros.Capacity == 0)
			{
				Console.WriteLine("A loja não tem livros no seu estoque.");
			}
			else
			{
				Console.WriteLine("A loja " + this.nome + " possui estes livros para venda: ");
				foreach (Livro livro in livros)
				{
					Console.WriteLine("Título: " + livro.Nome + ", preço: " + livro.Preco
							+ ", quantidade: " + livro.Qtd + " em estoque.");
				}
			}
			Console.WriteLine("---------------------------------------------------------------------------");
		}

		public void listaVideogames()
		{

			if (games.Capacity == 0)
			{
				Console.WriteLine("A loja não tem videogames no seu estoque.");
			}
			else
			{
				Console.WriteLine("A loja " + this.nome + " possui estes videogames para venda: ");

				foreach (Videogame videogame in games)
				{
					Console.WriteLine("Título: " + videogame.Nome + ", preço: " + videogame.Preco
							+ ", quantidade: " + videogame.Qtd + " em estoque.");
				}
			}
			Console.WriteLine("---------------------------------------------------------------------------");
		}

		public double calculaPatrimonio()
		{
			double patrimonio = 0;
			if (livros.Capacity == 0)
			{
				Console.WriteLine("A loja não tem livros no seu estoque.");
			}
			else
			{
				foreach (Livro livro in livros)
				{
					patrimonio += (livro.Preco * (double)livro.Qtd);
				}
			}
			if (games.Capacity == 0)
			{
				Console.WriteLine("A loja não tem videogames no seu estoque.");
			}
			else
			{
				foreach (Videogame videogame in games)
				{
					patrimonio += (videogame.Preco * (double)videogame.Qtd);
				}
			}
			Console.WriteLine("O patrimônio da loja " + this.nome + " é de R$ " + patrimonio);
			return 0;
		}
	}
}
