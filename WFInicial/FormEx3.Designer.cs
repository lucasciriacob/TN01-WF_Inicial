namespace WFInicial
{
    partial class FormEx3
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
            btnMaior = new Button();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(147, 174);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(116, 23);
            btnMaior.TabIndex = 0;
            btnMaior.Text = "Mostrar o Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(82, 36);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(82, 103);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Número 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(225, 33);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(225, 100);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // FormEx3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 227);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnMaior);
            Name = "FormEx3";
            Text = "FormEx3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMaior;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
    }
}