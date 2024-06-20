namespace ProjetoGitHub
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
            bt_mensagem = new Button();
            label1 = new Label();
            tb_nome = new TextBox();
            senha = new TextBox();
            email = new TextBox();
            tb_button1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(465, 237);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bt_mensagem
            // 
            bt_mensagem.DialogResult = DialogResult.Ignore;
            bt_mensagem.FlatAppearance.BorderSize = 2;
            bt_mensagem.Location = new Point(26, 234);
            bt_mensagem.Name = "bt_mensagem";
            bt_mensagem.Size = new Size(130, 23);
            bt_mensagem.TabIndex = 1;
            bt_mensagem.Text = "Exibir Mensagem";
            bt_mensagem.UseVisualStyleBackColor = true;
            bt_mensagem.Click += bt_mensagem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 135);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "OI EVELYN";
            label1.Click += label1_Click;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(12, 205);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(167, 23);
            tb_nome.TabIndex = 3;
            // 
            // senha
            // 
            senha.Location = new Point(228, 99);
            senha.Name = "senha";
            senha.Size = new Size(100, 23);
            senha.TabIndex = 4;
            // 
            // email
            // 
            email.Location = new Point(228, 70);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 5;
            // 
            // tb_button1
            // 
            tb_button1.Location = new Point(448, 205);
            tb_button1.Name = "tb_button1";
            tb_button1.Size = new Size(100, 23);
            tb_button1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(245, 163);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button2);
            Controls.Add(email);
            Controls.Add(senha);
            Controls.Add(tb_button1);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            Controls.Add(bt_mensagem);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bt_mensagem;
        private Label label1;
        private TextBox tb_nome;

        private TextBox senha;
        private TextBox email;

        private TextBox tb_button1;
        private Button button2;
    }
}
