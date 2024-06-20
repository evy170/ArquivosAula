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
            tb_mensagem = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(465, 237);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // bt_mensagem
            // 
            bt_mensagem.Location = new Point(12, 234);
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
            label1.Location = new Point(230, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "OI EVELYN";
            label1.Click += label1_Click;
            // 
            // tb_mensagem
            // 
            tb_mensagem.Location = new Point(12, 205);
            tb_mensagem.Name = "tb_mensagem";
            tb_mensagem.Size = new Size(130, 23);
            tb_mensagem.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tb_mensagem);
            Controls.Add(label1);
            Controls.Add(bt_mensagem);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bt_mensagem;
        private Label label1;
        private TextBox tb_mensagem;
    }
}
