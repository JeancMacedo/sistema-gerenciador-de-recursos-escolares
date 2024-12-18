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
    public partial class FormConfirmacao : Form
    {
        public FormConfirmacao()
        {
            InitializeComponent();
        }

        private void btnConfirmarConfirmacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltarConfirmacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
