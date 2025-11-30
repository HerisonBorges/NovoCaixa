using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeSupermercado
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public int Quantidade { get; set; }

		public override string ToString()
		{
			return $"ID: {Id} | Nome: {Nome} | Preço: {Preco} | Quantidade: {Quantidade}";
		}
	}
}

