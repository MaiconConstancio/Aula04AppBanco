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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double saldo;
            double valor;

            valor = Double.Parse(txtValor.Text); //Caixinha de texto
            saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));  // É ONDE TA O R$ e converte em numero
            double soma = saldo + valor;

            lblSaldo.Text = $"R$: {soma}";

            // ------------------------------------------- FAZER NOVAMENTE PQ A SALA N ENTENDEU --------------------------------------
            //-------------------------------------- |MESMA COISA| ------------------------------------------------------------

            //double valor = double.Parse(txtValor.Text);
            //double saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
            //double soma = saldo + valor;
            //lblSaldo.Text = $"R$: {soma}";

            //------------------------------------------------------------------------------------------------------------------
        }
    }
}
