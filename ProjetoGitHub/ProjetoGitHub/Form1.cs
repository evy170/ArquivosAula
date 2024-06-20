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
            MessageBox.Show("bem-vindo ao GITHUB!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
