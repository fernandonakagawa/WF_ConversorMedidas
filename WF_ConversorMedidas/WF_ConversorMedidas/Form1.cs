using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ConversorMedidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            float valor;
            try
            {
                valor = float.Parse(tbValor.Text);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Erro! Digite um valor numérico!");
                valor = 0;
                tbValor.Text = "";
            }

            if (rbMetros.Checked) valor /= 100;
            else if (rbCentimetros.Checked) valor *= 100;

            string sValor = valor.ToString();
            if (cbExibir.Checked) 
            {
                if (rbMetros.Checked) sValor += " m.";
                else if (rbCentimetros.Checked) sValor += " cm.";
            }
            lbValorConvertido.Text = sValor;
        }

        private void btnConverter_MouseEnter(object sender, EventArgs e)
        {
            lbInstrucoes.Text = "Clique em converter para realizar a conversão.";
        }

        private void btnConverter_MouseLeave(object sender, EventArgs e)
        {
            lbInstrucoes.Text = "Digite o valor a ser convertido.";
        }
    }
}
