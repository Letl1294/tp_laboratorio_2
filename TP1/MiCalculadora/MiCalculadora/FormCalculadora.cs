using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperador.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero primerNum;
            Numero segundoNum;
            String operador = cmbOperador.Text;

            primerNum = new Numero(textNumero1.Text);
            segundoNum = new Numero(txtNumero2.Text);
            lblResultado.Text = Convert.ToString(Calculadora.Operar(primerNum, segundoNum, operador));
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero(); 
            lblResultado.Text = Numero.DecimalBinario(Convert.ToDouble(lblResultado.Text));
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();
            lblResultado.Text = Numero.BinaroDecimal(lblResultado.Text);
        }
    }
}