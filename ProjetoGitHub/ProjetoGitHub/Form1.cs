namespace ProjetoGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_mensagem_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            MessageBox.Show($"Olá {nome}!!!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textButton1 = tb_button1.Text;
            MessageBox.Show($"texto do campo:  \n{textButton1} - Mais um texto");
            MessageBox.Show($"lendy inseriu mais um texto - Mais novidades");
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            string txt_email = email.Text;
            string txt_senha = senha.Text;
            MessageBox.Show($"Seu e-mail: {txt_email} \n senha: {txt_senha}");
        }
    }
}
