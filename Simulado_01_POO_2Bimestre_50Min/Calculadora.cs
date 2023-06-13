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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(textBox_Primeiro.Text);
                double number2 = Convert.ToDouble(textBox_Segundo.Text);
                if (radioButton1.Checked)
                {
                    textBox_Result.Text = Convert.ToString(number1 + number2);
                }
                else if (radioButton2.Checked)
                {
                    textBox_Result.Text = Convert.ToString(number1 - number2);
                }
                else if (radioButton3.Checked)
                {
                    textBox_Result.Text = Convert.ToString(number1 * number2);
                }
                else if (radioButton4.Checked)
                {
                    textBox_Result.Text = Convert.ToString(number1 / number2);
                }
            }
            catch (Exception ex)
            {
                textBox_Result.Text = "";
            }
        }
    }
}
