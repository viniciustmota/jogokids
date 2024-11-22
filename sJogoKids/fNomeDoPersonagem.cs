using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace sJogoKids
{
    public partial class fNomeDoPersonagem : Form
    {

        public fNomeDoPersonagem()
        {
            InitializeComponent();

            // Exibe o avatar selecionado
            if (UsuarioInfo.AvatarEscolhido != null)
            {
                imgProtetor.Image = UsuarioInfo.AvatarEscolhido;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fNomeDoPersonagem_Load(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nomeUsuario))
            {
                MessageBox.Show("Por favor, insira seu nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Salva o nome do usuário na classe estática
            UsuarioInfo.NomeUsuario = nomeUsuario;

            fTransicaoSenhaSegura transicaoSenhaSegura = new fTransicaoSenhaSegura();
            transicaoSenhaSegura.ShowDialog();
            this.Close();
        }

        private void imgProtetor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fEscolherPersonagem escolherPersonagem = new fEscolherPersonagem();
            escolherPersonagem.ShowDialog();

            // Fecha a tela atual
            this.Close();

        }
    }
}
