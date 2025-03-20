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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnConfirmarInicio_Click(object sender, EventArgs e)
        {
            if(rdbInventarioInicio.Checked == true)
            {
                FormInventario formInventario = new FormInventario();
                formInventario.ShowDialog();
            }

            if (rdbControleInicio.Checked == true)
            {
                FormControle formControle = new FormControle();
                formControle.ShowDialog();
            }
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
