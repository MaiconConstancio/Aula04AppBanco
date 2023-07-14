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

        List<string> extratos = new List<string>(); 
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


            if (txtDeposito.Text == "SAQUE")
            {
                double resultado = saldo - valor;
                lblSaldo.Text = $"R$: {resultado}";
                extratos.Add($"SAQUE no valor de R$ {valor}");

            }
            else
            {
                double resultado = saldo + valor;
                lblSaldo.Text = $"R$: {resultado}";
                extratos.Add($"DEPÓSITO no valor de R$ {valor}");
            }


            //lblSaldo.Text = $"R$: {resultado}";

            // ------------------------------------------- FAZER NOVAMENTE PQ A SALA N ENTENDEU --------------------------------------
            //-------------------------------------- |MESMA COISA| ------------------------------------------------------------

            //double valor = double.parse(txtvalor.text);
            //double saldo = double.parse(lblsaldo.text.replace("r$:", ""));
            //double soma = saldo + valor;
            //lblsaldo.text = $"r$: {soma}";
                        
            //------------------------------------------------------------------------------------------------------------------

            //------------------------------------------ |DEPOSITAR OU SACAR| ---------------------------------------------------

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.DarkGreen;
            btnDepositar.ForeColor = Color.Lime;

            btnSacar.BackColor = Color.Lime;
            btnSacar.ForeColor = Color.DarkGreen;
            txtDeposito.Text = "SAQUE";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            // Pintar o botão de Depositar
            btnDepositar.BackColor = Color.Lime;
            btnDepositar.ForeColor = Color.DarkGreen;

            // Pintar o botão de sacar
            btnSacar.BackColor = Color.DarkGreen;
            btnSacar.ForeColor = Color.Lime;
            txtDeposito.Text = "DEPÓSITO";

        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            FormsDoExtrato telaExtrato = new FormsDoExtrato();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();
        }
    }
}
