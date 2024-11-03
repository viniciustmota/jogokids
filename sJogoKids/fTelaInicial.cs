namespace sJogoKids
{
    public partial class fTelaInicial : Form
    {
        public fTelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEscolherPersonagem escolherPersonagem = new fEscolherPersonagem();
            escolherPersonagem.ShowDialog();
            this.Close();
        }
    }
}
