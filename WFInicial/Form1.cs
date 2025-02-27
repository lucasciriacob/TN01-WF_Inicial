namespace WFInicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1 = Convert.ToDouble(txtNota1.Text);
            double Nota2 = Convert.ToDouble(txtNota2.Text);
            double media = Nota1 + Nota2 / 2;

            if (media >= 7)
            {
                MessageBox.Show("Aprovado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (media < 5)
            {
                MessageBox.Show("Reprovado", "Deu Ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Recuperação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
