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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbCasdratro.Checked == true)
            {
                FormCadastro formCadastro = new FormCadastro();
                formCadastro.ShowDialog();
            }
            else if (rdbEdicao.Checked == true)
            {
                FormEdicao formEdicao = new FormEdicao();
                formEdicao.ShowDialog();
            }
            else if (rdbConsulta.Checked == true)
            {
                FormConsulta formConsulta = new FormConsulta();
                formConsulta.ShowDialog();
            }
            else if(rdbRelatorio.Checked == true)
            {
                FormRelatorio formRelatorio = new FormRelatorio();
                formRelatorio.ShowDialog();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
