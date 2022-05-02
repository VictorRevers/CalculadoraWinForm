# CalculadoraWinForm
Calculadora Simples com Windows Form .NET C#

# Questão
Elabore um programa que apresente uma pequena calculadora para as quatro operações aritméticas básicas. 
O programa deve aceitar a entrada de apenas dois valores numéricos reais, apresentar as operações para seleção e mostrar o resultado quando o botão de cálculo for 
acionado.

# Arquivo com as funcionalidades:
https://github.com/VictorRevers/CalculadoraWinForm/blob/master/CalculadoraSimples/Form1.cs

```
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
```
# Formulário:
![image](https://user-images.githubusercontent.com/60626825/166311074-3c965162-5de9-4dc9-868d-c46b6a3a89f1.png)

