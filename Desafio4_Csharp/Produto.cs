using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
	public abstract class Produto
	{
		

		public Produto(String nome, double preco, int qtd)
	{
		this.Nome = nome;
		this.Preco = preco;
		this.Qtd = qtd;
	}
		private String nome;
		private double preco;
		private int qtd;
		
		public String Nome { get; set; }
		public double Preco {get; set; }
		public int Qtd { get; set; }

		public void produto()
		{

		}

		public void produto(String nome, double preco, int qtd)
		{

		}

	
	}
}
