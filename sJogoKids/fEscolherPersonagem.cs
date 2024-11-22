using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sJogoKids
{
    public partial class fEscolherPersonagem : Form
    {
        public fEscolherPersonagem()
        {
            InitializeComponent();
        }

        private void AbrirNomeDoPersonagem()
        {
            fNomeDoPersonagem nomeDoPersonagem = new fNomeDoPersonagem();
            nomeDoPersonagem.ShowDialog();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorGato1.Image;
            AbrirNomeDoPersonagem();
        }

        private void imgProtetorAlien_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorAlien.Image;
            AbrirNomeDoPersonagem();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorDragao.Image;
            AbrirNomeDoPersonagem();
        }

        private void imgProtetorRato_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorRato.Image;
            AbrirNomeDoPersonagem();
        }

        private void imgProtetorRobo1_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorRobo1.Image;
            AbrirNomeDoPersonagem();
        }

        private void imgProtetorRaposa_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorRaposa.Image;
            AbrirNomeDoPersonagem();
        }

        private void imgProtetorRobo2_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorRobo2.Image;
            AbrirNomeDoPersonagem();
        }

        private void imgProtetorGato2_Click(object sender, EventArgs e)
        {
            UsuarioInfo.AvatarEscolhido = imgProtetorGato2.Image;
            AbrirNomeDoPersonagem();
        }

        private void fEscolherPersonagem_Load(object sender, EventArgs e)
        {

        }
    }
}
