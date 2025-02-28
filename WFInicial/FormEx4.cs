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
    public partial class FormEx4 : Form
    {
        public FormEx4()
        {
            InitializeComponent();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int num3 = Convert.ToInt32(txtNum3.Text);
            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            string message = $"O número {maior} é o maior número!";

            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
