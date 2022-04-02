using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmProduto : ControleEstoque1.FrmBase
    {
        public FrmProduto()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGridProduto();
        }

        private void CarregarGridProduto()
        {
            ModelProduto get = new ModelProduto();
            List<DtoProduto2> lista = get.ListProdutos();
            this.dataGridViewProduto.DataSource = lista;
            this.dataGridViewProduto.Refresh();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            textBoxNomeProduto.Text = string.Empty;
            textBoxIDProduto.Text = string.Empty;
            textBoxDescricaoProduto.Text = string.Empty;
            textBoxMarcaProduto.Text = string.Empty;
            LiberaCampos();
            textBoxNomeProduto.Focus();
        }

        private void LiberaCampos()
        {
            textBoxNomeProduto.Enabled = true;
            textBoxDescricaoProduto.Enabled = true;
            textBoxMarcaProduto.Enabled = true;
        }

        private void BloqueiaCampos()
        {
            textBoxIDProduto.Enabled = false;
            textBoxNomeProduto.Enabled = false;
            textBoxDescricaoProduto.Enabled = false;
            textBoxMarcaProduto.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                ModelProduto set = new ModelProduto();
                DtoProduto pro = new DtoProduto();
                pro.nome_produto = textBoxNomeProduto.Text;
                pro.descricao = textBoxDescricaoProduto.Text;
                pro.marca = textBoxMarcaProduto.Text;
                if (textBoxIDProduto.Text != string.Empty)
                {
                    pro.id_produto = int.Parse(textBoxIDProduto.Text);
                    set.EditProduto(pro);
                }
                else
                {
                    set.SetProduto(pro);
                }

                BloqueiaCampos();
                CarregarGridProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewProduto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IDProduto = (Int32)dataGridViewProduto.CurrentRow.Cells[0].Value;

            ModelProduto get = new ModelProduto();
            DtoProduto2 d = get.GetProdutoId(IDProduto);
            textBoxIDProduto.Text = d.id_produto.ToString();
            textBoxNomeProduto.Text = d.nome_produto;
            LiberaCampos();
            textBoxNomeProduto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberaCampos();
            textBoxNomeProduto.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxIDProduto.Text != string.Empty)
            {
                ModelProduto del = new ModelProduto();
                del.DeletarProduto(int.Parse(textBoxIDProduto.Text));
                BloqueiaCampos();
                CarregarGridProduto();
                LimparTodosOsCampos();
            }
        }

        private void LimparTodosOsCampos()
        {
            textBoxNomeProduto.Text = string.Empty;
            textBoxIDProduto.Text = string.Empty;
            textBoxDescricaoProduto.Text = string.Empty;
            textBoxMarcaProduto.Text = string.Empty;
        }
    }
}
