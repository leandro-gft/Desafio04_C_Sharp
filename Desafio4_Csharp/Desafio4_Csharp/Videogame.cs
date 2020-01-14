using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio4_Csharp
{
	public class Videogame : Produto, Imposto
	{

		public Videogame(String nome, double preco, int qtd, String marca, String modelo, bool isUsado) : base(nome, preco, qtd)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.isUsado = isUsado;

		}

		private String marca;
		private String modelo;
		private bool isUsado;

		public string Marca { get { return marca; } set { marca = value; } }
		public string Modelo { get { return modelo; } set { modelo = value; } }
		public bool IsUsado { get { return isUsado; } set { isUsado = value; } }

		public void videogame()
		{

		}

		public void videogame(String nome, double preco, int qtd, String marca, String modelo, bool isUsado)
		{

		}

		public double calculaImposto()
		{
			if (isUsado == true)
			{
				String use = "usado";
				Console.WriteLine("O " + this.Nome + " " + modelo + " " + use + " tem imposto igual a R$ " + 0.25 * this.Preco);
				return 0;
			}
			else
			{
				Console.WriteLine("O " + this.Nome + " " + modelo + " tem imposto igual a R$ " + 0.45 * this.Preco);
				return 0;
			}
		}
	}
}

