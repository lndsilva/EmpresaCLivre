using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        public frmCalculadora()
        {
            InitializeComponent();
        }

        //essa é uma ação do botão somar
        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando as variáveis da soma
            double num1, num2, resp = 0.0;

            //inicializando as variáveis
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //realizando o calculo de soma
            resp = num1 + num2;

            lblResposta.Text = resp.ToString();
            bandeira = true;

        }
        //escopo global
        bool bandeira;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            bandeira = false;
            txtNum1.Clear();
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }

       

    }
}
