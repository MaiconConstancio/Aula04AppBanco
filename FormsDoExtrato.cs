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
        public List<string> extratos = new List<string>();
        public FormsDoExtrato()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormsDoExtrato telaExtrato = new FormsDoExtrato();
            telaExtrato.Show();
        }

        private void FormsDoExtrato_Load(object sender, EventArgs e)
        {
            //listExtratos.Items.Add("");


            for (int i = 0; i < extratos.Count; i++) //em vez de usar o contador vc usa o i, (antes e depois) (contador++;) agora == (i++;)
            {
                listExtratos.Items.Add(extratos[i]);
            }

        }
    }
}
