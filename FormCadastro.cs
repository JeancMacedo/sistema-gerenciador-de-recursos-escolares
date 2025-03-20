using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FormCadastro : Form
    {
        Estoque estoque = new Estoque();
        
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnConfirmarCadastro_Click(object sender, EventArgs e)
        {
            string nome = cmbCadastro.Text;
            int quantidade = int.Parse(txbQuantidadeCadastro.Text);
            int categoria = 1;
            int validade = 2;
            int tipo = 3;
            FormConfirmacao formConfirmacao = new FormConfirmacao();
            formConfirmacao.ShowDialog();
            estoque.adicionarAlimento(new Alimento (nome, quantidade, categoria, validade, tipo));
            MessageBox.Show("Alimento cadastrado com sucesso");
            
        }

        private void btnLimparCadastro_Click(object sender, EventArgs e)
        {
            estoque.retornaAlimentos();
        }

        private void btnVoltarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
