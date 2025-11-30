namespace CaixaDeSupermercado
{
	partial class TelaEstoque
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textNome = new System.Windows.Forms.TextBox();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lstProdutos = new System.Windows.Forms.ListBox();
			this.btnListar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Preço";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Quantidade";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "ID";
			// 
			// textNome
			// 
			this.textNome.Location = new System.Drawing.Point(131, 21);
			this.textNome.Name = "textNome";
			this.textNome.Size = new System.Drawing.Size(218, 20);
			this.textNome.TabIndex = 4;
			// 
			// txtPreco
			// 
			this.txtPreco.Location = new System.Drawing.Point(131, 60);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(218, 20);
			this.txtPreco.TabIndex = 5;
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(131, 99);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(218, 20);
			this.txtQuantidade.TabIndex = 6;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(131, 145);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(218, 20);
			this.txtId.TabIndex = 7;
			// 
			// lstProdutos
			// 
			this.lstProdutos.FormattingEnabled = true;
			this.lstProdutos.Location = new System.Drawing.Point(220, 291);
			this.lstProdutos.Name = "lstProdutos";
			this.lstProdutos.Size = new System.Drawing.Size(319, 147);
			this.lstProdutos.TabIndex = 12;
			// 
			// btnListar
			// 
			this.btnListar.Image = global::CaixaDeSupermercado.Properties.Resources.iconeListar;
			this.btnListar.Location = new System.Drawing.Point(548, 225);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(75, 47);
			this.btnListar.TabIndex = 11;
			this.btnListar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Image = global::CaixaDeSupermercado.Properties.Resources.iconeExcluir;
			this.btnExcluir.Location = new System.Drawing.Point(402, 225);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 47);
			this.btnExcluir.TabIndex = 10;
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Image = global::CaixaDeSupermercado.Properties.Resources.iconeEditar;
			this.btnEditar.Location = new System.Drawing.Point(265, 225);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 47);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Image = global::CaixaDeSupermercado.Properties.Resources.iconeAdicionar;
			this.btnAdicionar.Location = new System.Drawing.Point(131, 225);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 47);
			this.btnAdicionar.TabIndex = 8;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// TelaEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lstProdutos);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.textNome);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TelaEstoque";
			this.Text = "TelaEstoque";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textNome;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.ListBox lstProdutos;
	}
}
