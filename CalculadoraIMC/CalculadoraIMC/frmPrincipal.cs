using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;
        }
        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            {
                txtAltura.ResetText();
            }
            if (txtAltura.BackColor == Color.Red)
            {
                txtAltura.ResetText();
            }
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            {
                if(!txtPeso.Text.Contains(","))
                {
                    txtPeso.Text += (sender as Button).Text;
                }
            }
            if (txtAltura.BackColor == Color.Red)
            {
                if (!txtPeso.Text.Contains(","))
                {
                    txtPeso.Text += (sender as Button).Text;
                }
            }
        }
        private void GerarNúmero(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            {
                txtPeso.Text += (sender as Button).Text;
            }
            if (txtAltura.BackColor == Color.Red)
            {
                txtAltura.Text += (sender as Button).Text;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text); //OU float.Parse(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);//OU float.Parse(txtAltura.Text);

            double imc = peso / (altura * altura);

            txtIMC.Text = imc.ToString("N2");

            if(imc < 19.1)
            {
                lblSituacao.Text = "Abaixo do peso.";
            }
            else 
            {
                if (imc >= 19.1 && imc < 25.8)
                {
                    lblSituacao.Text = "Peso normal.";
                }
                else
                {
                    if(imc >= 25.8 && imc < 32.3)
                    {
                        lblSituacao.Text = "Acima do peso.";
                    }
                    else
                    {
                        lblSituacao.Text = "Obeso.";
                    }
                }
            }
        }
        
    }
}   
