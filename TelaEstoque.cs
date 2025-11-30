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
	public partial class TelaEstoque : Form
	{
		List<Produto> produtos = new List<Produto>();
		int proximoId = 1;


		private void SalvarNoArquivo()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter("produtos.txt"))
			{
				foreach (Produto p in produtos)
				{
					sw.WriteLine(p.Id + ";" + p.Nome + ";" + p.Preco + ";" + p.Quantidade);
				}
			}
		}

		private void CarregarDoArquivo()
		{
			if (!System.IO.File.Exists("produtos.txt"))
				return;

			string[] linhas = System.IO.File.ReadAllLines("produtos.txt");

			foreach (string linha in linhas)
			{
				string[] dados = linha.Split(';');

				Produto p = new Produto();
				p.Id = int.Parse(dados[0]);
				p.Nome = dados[1];
				p.Preco = decimal.Parse(dados[2]);
				p.Quantidade = int.Parse(dados[3]);

				produtos.Add(p);
			}

			if (produtos.Count > 0)
				proximoId = produtos[produtos.Count - 1].Id + 1;
		}


		public TelaEstoque()
		{
			InitializeComponent();

			btnAdicionar.Click += btnAdicionar_Click;
			btnEditar.Click += btnEditar_Click;
			btnExcluir.Click += btnExcluir_Click;
			btnListar.Click += btnListar_Click;
			lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;

			CarregarDoArquivo();
			AtualizarLista();
		}


		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textNome.Text) ||
				string.IsNullOrWhiteSpace(txtPreco.Text) ||
				string.IsNullOrWhiteSpace(txtQuantidade.Text))
			{
				MessageBox.Show("Preencha todos os campos antes de adicionar!");
				return;
			}

			decimal preco;
			int quantidade;

			if (!decimal.TryParse(txtPreco.Text, out preco))
			{
				MessageBox.Show("Preço inválido! Digite apenas números.");
				return;
			}

			if (!int.TryParse(txtQuantidade.Text, out quantidade))
			{
				MessageBox.Show("Quantidade inválida! Digite um número inteiro.");
				return;
			}

			Produto p = new Produto();
			p.Id = proximoId++;
			p.Nome = textNome.Text;
			p.Preco = preco;
			p.Quantidade = quantidade;

			produtos.Add(p);
			AtualizarLista();
			LimparCampos();
			SalvarNoArquivo();


			MessageBox.Show("Produto adicionado!");
		}


		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (txtId.Text == "")
			{
				MessageBox.Show("Selecione um produto!");
				return;
			}

			int id = Convert.ToInt32(txtId.Text);
			Produto p = produtos.FirstOrDefault(x => x.Id == id);

			if (p != null)
			{
				p.Nome = textNome.Text;
				p.Preco = Convert.ToDecimal(txtPreco.Text);
				p.Quantidade = Convert.ToInt32(txtQuantidade.Text);

				AtualizarLista();
				LimparCampos();
				SalvarNoArquivo();


				MessageBox.Show("Produto editado!");
			}
		}

		
		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (txtId.Text == "")
			{
				MessageBox.Show("Selecione um produto!");
				return;
			}

			int id = Convert.ToInt32(txtId.Text);
			Produto p = produtos.FirstOrDefault(x => x.Id == id);

			if (p != null)
			{
				produtos.Remove(p);
				AtualizarLista();
				LimparCampos();
				SalvarNoArquivo();

				MessageBox.Show("Produto excluído!");
			}
		}

		
		private void btnListar_Click(object sender, EventArgs e)
		{
			AtualizarLista();
		}

		
		private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstProdutos.SelectedItem == null)
				return;

			Produto p = (Produto)lstProdutos.SelectedItem;

			textNome.Text = p.Nome;
			txtPreco.Text = p.Preco.ToString();
			txtQuantidade.Text = p.Quantidade.ToString();
			txtId.Text = p.Id.ToString();
		}

		
		// --------------------------
		private void AtualizarLista()
		{
			lstProdutos.DataSource = null;
			lstProdutos.DataSource = produtos;
			
		}

		private void LimparCampos()
		{
			textNome.Text = "";
			txtPreco.Text = "";
			txtQuantidade.Text = "";
			txtId.Text = "";
		}
	}
}
