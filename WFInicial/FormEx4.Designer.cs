namespace WFInicial
{
    partial class FormEx4
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
            lblNum3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            SuspendLayout();
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(111, 161);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(121, 23);
            btnMaior.TabIndex = 0;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(87, 9);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(87, 57);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Número 2";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(87, 112);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(57, 15);
            lblNum3.TabIndex = 3;
            lblNum3.Text = "Número3";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(152, 6);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(152, 54);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 5;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(152, 109);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 6;
            // 
            // FormEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnMaior);
            Name = "FormEx4";
            Text = "FormEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMaior;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
    }
}