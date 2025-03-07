using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, num1, num2 = 0;
            bool ehValidoNum1 = double.TryParse(txtNum1.Text, out num1);
            bool ehValidoNum2 = double.TryParse(txtNum2.Text, out num2);

            if(!ehValidoNum1 || !ehValidoNum2)
            {
                MessageBox.Show("Os valores digitados não são números!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdbSoma.Checked)
                {
                    resultado = num1 + num2;
                    string message = $"A soma de {num1} + {num2} = {resultado}";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdbSubtracao.Checked)
                {
                    resultado = num1 - num2;
                    string message = $"A subtração de {num1} - {num2} = {resultado}";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdbMultiplicacao.Checked)
                {
                    resultado = num1 * num2;
                    string message = $"A multiplicação de {num1} x {num2} = {resultado}";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdbDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("O denominador não pode ser igual a 0!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        resultado = num1 / num2;
                        string message = $"A divisão de {num1} / {num2} = {resultado}";
                        MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rdbPotenciacao.Checked)
                {
                    resultado = Math.Pow(num1, num2);
                    string message = $"A potenciação de {num1} ^ {num2} = {resultado}";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdbRadiacao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("O denominador não pode ser igual a 0!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        resultado = Math.Pow(num1, (1 / num2));
                        string message = $"A raiz de {num1} ^ {num2} = {resultado}";
                        MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Você deve escolher uma operação!", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
