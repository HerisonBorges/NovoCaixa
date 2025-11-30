using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaDeSupermercado
{
	public partial class TelaListagemProdutos : Form
	{
		private List<Produto> listaDeProdutos;
		public TelaListagemProdutos()
		{
			InitializeComponent();
		}

		public TelaListagemProdutos(List<Produto> produtos) : this()
		{
			this.listaDeProdutos = produtos;
			CarregarGrid();
		}

		private void CarregarGrid()
		{
			this.dgvProdutos.DataSource = null;
			this.dgvProdutos.DataSource = this.listaDeProdutos;

			this.dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProdutos.ReadOnly = true;
		}
	}
}