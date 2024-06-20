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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(664, 395);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // bt_mensagem
            // 
            bt_mensagem.Location = new Point(17, 390);
            bt_mensagem.Margin = new Padding(4, 5, 4, 5);
            bt_mensagem.Name = "bt_mensagem";
            bt_mensagem.Size = new Size(186, 38);
            bt_mensagem.TabIndex = 1;
            bt_mensagem.Text = "Exibir Mensagem";
            bt_mensagem.UseVisualStyleBackColor = true;
            bt_mensagem.Click += bt_mensagem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 166);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "OI EVELYN";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(bt_mensagem);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bt_mensagem;
        private Label label1;
    }
}
