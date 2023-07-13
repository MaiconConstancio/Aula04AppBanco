using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class FormsDoExtrato : Form
    {
        public FormsDoExtrato()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormsDoExtrato telaExtrato = new FormsDoExtrato();
            telaExtrato.Show();
        }
    }
}
