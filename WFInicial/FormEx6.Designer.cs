namespace WFInicial
{
    partial class FormEx6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalc = new Button();
            lblNome = new Label();
            lblHoras = new Label();
            lblValor = new Label();
            txtNome = new TextBox();
            txtHoras = new TextBox();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(167, 180);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(126, 52);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(89, 92);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(103, 15);
            lblHoras.TabIndex = 2;
            lblHoras.Text = "Horas Trabalhadas";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(102, 135);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(88, 15);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor das Horas";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(196, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(196, 89);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 5;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(196, 132);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 6;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValor);
            Controls.Add(txtHoras);
            Controls.Add(txtNome);
            Controls.Add(lblValor);
            Controls.Add(lblHoras);
            Controls.Add(lblNome);
            Controls.Add(btnCalc);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private Label lblNome;
        private Label lblHoras;
        private Label lblValor;
        private TextBox txtNome;
        private TextBox txtHoras;
        private TextBox txtValor;
    }
}