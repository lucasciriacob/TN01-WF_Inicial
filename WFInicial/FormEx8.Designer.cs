namespace WFInicial
{
    partial class FormEx8
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblNum2 = new Label();
            rdbSoma = new RadioButton();
            gbxOperacao = new GroupBox();
            rdbRadiacao = new RadioButton();
            rdbPotenciacao = new RadioButton();
            rdbDivisao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbSubtracao = new RadioButton();
            btnCalcular = new Button();
            gbxOperacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(123, 88);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(201, 84);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(201, 174);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(123, 182);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Número 2";
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(6, 22);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 5;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // gbxOperacao
            // 
            gbxOperacao.Controls.Add(rdbRadiacao);
            gbxOperacao.Controls.Add(rdbPotenciacao);
            gbxOperacao.Controls.Add(rdbDivisao);
            gbxOperacao.Controls.Add(rdbMultiplicacao);
            gbxOperacao.Controls.Add(rdbSubtracao);
            gbxOperacao.Controls.Add(rdbSoma);
            gbxOperacao.Location = new Point(342, 31);
            gbxOperacao.Name = "gbxOperacao";
            gbxOperacao.Size = new Size(200, 166);
            gbxOperacao.TabIndex = 6;
            gbxOperacao.TabStop = false;
            gbxOperacao.Text = "Operação";
            // 
            // rdbRadiacao
            // 
            rdbRadiacao.AutoSize = true;
            rdbRadiacao.Location = new Point(6, 143);
            rdbRadiacao.Name = "rdbRadiacao";
            rdbRadiacao.Size = new Size(73, 19);
            rdbRadiacao.TabIndex = 10;
            rdbRadiacao.TabStop = true;
            rdbRadiacao.Text = "Radiação";
            rdbRadiacao.UseVisualStyleBackColor = true;
            // 
            // rdbPotenciacao
            // 
            rdbPotenciacao.AutoSize = true;
            rdbPotenciacao.Location = new Point(5, 121);
            rdbPotenciacao.Name = "rdbPotenciacao";
            rdbPotenciacao.Size = new Size(90, 19);
            rdbPotenciacao.TabIndex = 9;
            rdbPotenciacao.TabStop = true;
            rdbPotenciacao.Text = "Potenciação";
            rdbPotenciacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(6, 96);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 8;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(6, 71);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(97, 19);
            rdbMultiplicacao.TabIndex = 7;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(5, 48);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 6;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(289, 250);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(gbxOperacao);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "FormEx8";
            Text = "FormEx8";
            gbxOperacao.ResumeLayout(false);
            gbxOperacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblNum2;
        private RadioButton rdbSoma;
        private GroupBox gbxOperacao;
        private RadioButton rdbRadiacao;
        private RadioButton rdbPotenciacao;
        private RadioButton rdbDivisao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbSubtracao;
        private Button btnCalcular;
    }
}