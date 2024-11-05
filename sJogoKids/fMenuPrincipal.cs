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
    public partial class fMenuPrincipal : Form
    {
        public fMenuPrincipal()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximiza o formulário

            // Configurar o mediaPlayer para ancorar em todos os lados do formulário
            mediaPlayer.Dock = DockStyle.Fill;

            // Caminho do vídeo
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Video", "bgMenuPrincipal.mp4");

            if (File.Exists(path))
            {
                mediaPlayer.URL = path;
                mediaPlayer.settings.autoStart = true;
                mediaPlayer.uiMode = "none";
                mediaPlayer.settings.setMode("loop", true);  // Ativa o loop
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEscolherPersonagem nomeDoPersonagem = new fEscolherPersonagem();
            nomeDoPersonagem.ShowDialog();
            this.Close();
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void fMenuPrincipal_Load(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }
    }
}
