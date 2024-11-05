﻿using System;
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
            this.Close();
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

        

    }
}
