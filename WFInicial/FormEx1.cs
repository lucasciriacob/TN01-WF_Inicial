namespace WFInicial
{
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show(
                    "Aprovado",
                    "Ok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (media < 5)
            {
                MessageBox.Show(
                    "Reprovado",
                    "Deu Ruim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    "Recupera��o",
                    "Aten��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
