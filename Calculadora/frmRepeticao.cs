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
    public partial class frmRepeticao : Form
    {
        public frmRepeticao()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            cbbCategorias.Items.Clear();
            cbbCategorias.Items.Add("Vestuário");
            cbbCategorias.Items.Add("Pescados");
            cbbCategorias.Items.Add("Bebidas");
            cbbCategorias.Items.Add("Padaria");
            cbbCategorias.Items.Add("Medicamentos");
            cbbCategorias.Items.Add("Cosméticos");
            cbbCategorias.Items.Add("Frutas");
            cbbCategorias.Items.Add("Pets");
            cbbCategorias.Items.Add("Calçados");
            cbbCategorias.Items.Add("Eletrodomésticos");

            //criando um vetor
            int[] valor = new int[5];

            //inserindo valores no vetor
            valor[0] = 10;
            valor[1] = 20;
            valor[2] = 30;
            valor[3] = 50;
            valor[4] = 100;

            cbbCategorias.Items.Add(valor[0]);

        }
    }
}
