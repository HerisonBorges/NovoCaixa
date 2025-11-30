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
	public partial class TelaPrincipal : Form
	{
		public TelaPrincipal()
		{
			InitializeComponent();
		}

		private void btnEstoque_Click(object sender, EventArgs e)
		{
			TelaEstoque tela = new TelaEstoque();
			tela.Show(); 
		}

		private void btnProdutos_Click(object sender, EventArgs e)
		{
			TelaProdutos tela = new TelaProdutos();
			tela.Show();
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			TelaClientes tela = new TelaClientes();
			tela.Show();
		}

	}
}
