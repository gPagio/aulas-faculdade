namespace verifica_palindromo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            TituloPrincipal = new Label();
            EntradaDeTexto = new TextBox();
            label1 = new Label();
            RetornoVerificacao = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(342, 261);
            button1.Name = "button1";
            button1.Size = new Size(126, 32);
            button1.TabIndex = 1;
            button1.Text = "Processar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TituloPrincipal
            // 
            TituloPrincipal.AutoSize = true;
            TituloPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TituloPrincipal.Location = new Point(312, 190);
            TituloPrincipal.Name = "TituloPrincipal";
            TituloPrincipal.Size = new Size(181, 28);
            TituloPrincipal.TabIndex = 2;
            TituloPrincipal.Text = "Digite uma palavra:";
            TituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EntradaDeTexto
            // 
            EntradaDeTexto.Location = new Point(312, 221);
            EntradaDeTexto.Multiline = true;
            EntradaDeTexto.Name = "EntradaDeTexto";
            EntradaDeTexto.Size = new Size(181, 34);
            EntradaDeTexto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(736, 67);
            label1.TabIndex = 4;
            label1.Text = "VERIFICADOR DE PALINDROMO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // RetornoVerificacao
            // 
            RetornoVerificacao.AutoSize = true;
            RetornoVerificacao.Location = new Point(302, 345);
            RetornoVerificacao.Name = "RetornoVerificacao";
            RetornoVerificacao.Size = new Size(204, 20);
            RetornoVerificacao.TabIndex = 5;
            RetornoVerificacao.Text = "Ser ou Nao Ser, Eis a Questão";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RetornoVerificacao);
            Controls.Add(label1);
            Controls.Add(EntradaDeTexto);
            Controls.Add(TituloPrincipal);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label TituloPrincipal;
        private TextBox EntradaDeTexto;
        private Label label1;
        private Label RetornoVerificacao;
    }
}