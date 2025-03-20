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
    public partial class FormEdicao : Form
    {
        public FormEdicao()
        {
            InitializeComponent();
        }

        private void btnVoltarEdicao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
