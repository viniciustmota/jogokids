using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sJogoKids
{
    public partial class fSenhaSegura : Form
    {
        public fSenhaSegura()
        {
            InitializeComponent();


            // Exibe o avatar selecionado
            if (UsuarioInfo.AvatarEscolhido != null)
            {
                imgProtetor.Image = UsuarioInfo.AvatarEscolhido;
            }



            lblNickname.Text = $"{UsuarioInfo.NomeUsuario}";


            // Configura o Timer
            timer1.Interval = 1000; // Define o intervalo para 5 segundos
            timer1.Tick += Timer1_Tick; // Adiciona o evento Tick do Timer
            timer1.Start(); // Inicia o Timer
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool VerificarSenhaSegura(string senha)
        {
            // Verifica se a senha atende aos critérios de segurança
            if (senha.Length < 8) return false; // Mínimo de 8 caracteres
            if (!Regex.IsMatch(senha, @"[A-Z]")) return false; // Pelo menos uma letra maiúscula
            if (!Regex.IsMatch(senha, @"[a-z]")) return false; // Pelo menos uma letra minúscula
            if (!Regex.IsMatch(senha, @"[0-9]")) return false; // Pelo menos um número
            if (!Regex.IsMatch(senha, @"[\W_]")) return false; // Pelo menos um caractere especial

            return true; // A senha é segura
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text; // Supondo que você tenha um TextBox chamado txtSenha
            string repetirSenha = txtRepetirSenha.Text; // E outro chamado txtRepetirSenha

            if (VerificarSenhaSegura(senha) && senha == repetirSenha)
            {
                MessageBox.Show("Senha segura e confirmada!");
                // Aqui você pode prosseguir com a lógica após a confirmação da senha
            }
            else
            {
                MessageBox.Show("Senha insegura ou as senhas não coincidem. Tente novamente.");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Para o Timer para que não fique disparando
            timer1.Stop();

            // Altera a visibilidade da imagem
            mensagemDeAjuda.Visible = !mensagemDeAjuda.Visible; // Alterna a visibilidade
        }
        private void mensagemDeAjuda_Click_1(object sender, EventArgs e)
        {
            mensagemDeAjuda.Visible = false;
        }

        private void fSenhaSegura_Load(object sender, EventArgs e)
        {

        }

        private void btnAjuda_Click_1(object sender, EventArgs e)
        {
            mensagemDeAjuda.Visible = !mensagemDeAjuda.Visible; // Inverte a visibilidade
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgProtetor_Click(object sender, EventArgs e)
        {

        }
    }
}
