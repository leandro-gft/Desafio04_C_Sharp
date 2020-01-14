using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
	public class Livro : Produto, Imposto
	{

		public Livro(String nome, double preco, int qtd, String autor, String tema, int qtdPag) : base(nome, preco, qtd)
		{
			this.autor = autor;
			this.tema = tema;
			this.qtdPag = qtdPag;
		}
		private String autor;
		private String tema;
		private int qtdPag;

		public string Autor { get { return autor; } set { autor = value; } }
		public string Tema { get { return tema; } set { tema = value; } }
		public int QtdPag { get { return qtdPag; } set { qtdPag = value; } }

		public void livro()
		{

		}
		public void livro(String nome, double preco, int qtd, String autor, String tema, int qtdPag)
		{

		}
	
		public double calculaImposto()
		{
			if (tema == "educativo")
			{
				Console.WriteLine("Não há imposto para o livro " + this.Nome + ", uma vez que seu tema é " + this.Tema);
				return 0;
			}
			else
			{
				Console.WriteLine("O livro " + this.Nome + ", possui imposto igual R$ " + 0.1 * this.Preco);
				return 0;
			}
		}
	}
}
