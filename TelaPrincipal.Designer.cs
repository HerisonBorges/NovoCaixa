namespace CaixaDeSupermercado
{
	partial class TelaPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnEstoque = new System.Windows.Forms.Button();
			this.btnProdutos = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.panelMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelMenu.Controls.Add(this.btnClientes);
			this.panelMenu.Controls.Add(this.btnProdutos);
			this.panelMenu.Controls.Add(this.btnEstoque);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(200, 450);
			this.panelMenu.TabIndex = 0;
			// 
			// btnEstoque
			// 
			this.btnEstoque.Location = new System.Drawing.Point(56, 54);
			this.btnEstoque.Name = "btnEstoque";
			this.btnEstoque.Size = new System.Drawing.Size(75, 23);
			this.btnEstoque.TabIndex = 0;
			this.btnEstoque.Text = "Estoque";
			this.btnEstoque.UseVisualStyleBackColor = true;
			this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
			// 
			// btnProdutos
			// 
			this.btnProdutos.Location = new System.Drawing.Point(56, 196);
			this.btnProdutos.Name = "btnProdutos";
			this.btnProdutos.Size = new System.Drawing.Size(75, 23);
			this.btnProdutos.TabIndex = 1;
			this.btnProdutos.Text = "Produtos";
			this.btnProdutos.UseVisualStyleBackColor = true;
			this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Location = new System.Drawing.Point(56, 344);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(75, 23);
			this.btnClientes.TabIndex = 2;
			this.btnClientes.Text = "Clientes";
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelMenu);
			this.Name = "TelaPrincipal";
			this.Text = "Form1";
			this.panelMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnProdutos;
		private System.Windows.Forms.Button btnEstoque;
	}
}

