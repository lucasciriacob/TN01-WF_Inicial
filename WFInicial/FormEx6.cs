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
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int horas = Convert.ToInt32(txtHoras.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            double salario = horas * valor;

            string message = $"O funcionário {nome} trabalhou {horas} horas e deve receber R${salario}";
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
