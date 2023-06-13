using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado_01_POO_2Bimestre_50Min
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            mascara_CPF.Text = "";
            mascara_Senha.Text = "";
            mascara_Confirmar.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if(mascara_Senha.Text == mascara_Confirmar.Text && mascara_Confirmar.Text !="")
            {
                Calculadora a1 = new Calculadora();
                a1.ShowDialog();
            }
        }
    }
}
