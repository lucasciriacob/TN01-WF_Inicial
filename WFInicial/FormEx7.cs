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
    public partial class FormEx7 : Form
    {
        public string[] Listanomeproduto = new string[6];
        public double[] Listaprecoproduto = new double[6];
        public int contador = 0;
        public FormEx7()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            contador = contador +1;
            Listanomeproduto[contador - 1] = txtNome.Text;
            Listaprecoproduto[contador - 1] = Convert.ToDouble(txtPreco.Text);

            txtNome.Text = "";
            txtPreco.Text = "";

            if (contador == 6)
            {
                double menor = Listaprecoproduto.Min();
                int pos_menor = Array.IndexOf(Listaprecoproduto, menor);
                string message = $"O produto mais barato é {Listanomeproduto[pos_menor]} de valor {menor}";
                MessageBox.Show(message);
            }
        }
    }
}
