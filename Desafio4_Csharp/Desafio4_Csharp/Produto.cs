using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
	public abstract class Produto
	{
		public Produto(String nome, double preco, int qtd)
		{
			this.nome = nome;
			this.preco = preco;
			this.qtd = qtd;
		}

		private String nome;
		private double preco;
		private int qtd;
		
		public String Nome { get { return nome; } set { nome = value; } }
		public double Preco { get { return preco; } set { preco = value; } }
		public int Qtd { get { return qtd; } set { qtd = value; } }

		public void produto()
		{

		}

		public void produto(String nome, double preco, int qtd)
		{

		}

	
	}
}
