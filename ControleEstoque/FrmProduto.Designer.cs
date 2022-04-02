namespace ControleEstoque1
{
    partial class FrmProduto
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
            this.lblIDProduto = new System.Windows.Forms.Label();
            this.textBoxIDProduto = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.textBoxMarcaProduto = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblIDProduto
            // 
            this.lblIDProduto.AutoSize = true;
            this.lblIDProduto.Location = new System.Drawing.Point(8, 131);
            this.lblIDProduto.Name = "lblIDProduto";
            this.lblIDProduto.Size = new System.Drawing.Size(18, 13);
            this.lblIDProduto.TabIndex = 17;
            this.lblIDProduto.Text = "ID";
            // 
            // textBoxIDProduto
            // 
            this.textBoxIDProduto.Location = new System.Drawing.Point(99, 128);
            this.textBoxIDProduto.Name = "textBoxIDProduto";
            this.textBoxIDProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDProduto.TabIndex = 16;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(264, 184);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 184);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(8, 154);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 13;
            this.lblNomeProduto.Text = "Nome";
            // 
            // textBoxMarcaProduto
            // 
            this.textBoxMarcaProduto.Location = new System.Drawing.Point(334, 177);
            this.textBoxMarcaProduto.Name = "textBoxMarcaProduto";
            this.textBoxMarcaProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarcaProduto.TabIndex = 12;
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(99, 177);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricaoProduto.TabIndex = 11;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(99, 151);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(335, 20);
            this.textBoxNomeProduto.TabIndex = 10;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Location = new System.Drawing.Point(11, 212);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.Size = new System.Drawing.Size(733, 150);
            this.dataGridViewProduto.TabIndex = 18;
            this.dataGridViewProduto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduto_CellMouseDoubleClick);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.lblIDProduto);
            this.Controls.Add(this.textBoxIDProduto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.textBoxMarcaProduto);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Name = "FrmProduto";
            this.Text = "Cadastro de Produto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.textBoxNomeProduto, 0);
            this.Controls.SetChildIndex(this.textBoxDescricaoProduto, 0);
            this.Controls.SetChildIndex(this.textBoxMarcaProduto, 0);
            this.Controls.SetChildIndex(this.lblNomeProduto, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.textBoxIDProduto, 0);
            this.Controls.SetChildIndex(this.lblIDProduto, 0);
            this.Controls.SetChildIndex(this.dataGridViewProduto, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDProduto;
        private System.Windows.Forms.TextBox textBoxIDProduto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox textBoxMarcaProduto;
        private System.Windows.Forms.TextBox textBoxDescricaoProduto;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
    }
}
