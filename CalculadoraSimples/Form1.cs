using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float som(float a, float b)
        {
            float resultado = a + b;
            return resultado;
        }

        public float sub(float a, float b)
        {
            float resultado = a - b;
            return resultado;
        }

        public float mul(float a, float b)
        {
            float resultado = a * b;
            return resultado;
        }

        public float div(float a, float b)
        {
            float resultado = a / b;
            return resultado;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            float resultado, a = float.Parse(textBox1.Text),  b = float.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
               resultado = som(a, b);
            }else if (radioButton2.Checked)
            {
                resultado = sub(a, b);
            }else if (radioButton3.Checked)
            {
                resultado = mul(a, b);
            }
            else
            {
                resultado = div(a, b);
            }

            richTextBox1.Text = resultado.ToString();
        }
    }
}
