using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace sJogoKids
{
    public partial class fMenuPrincipal : Form
    {

        private List<string> playlist = new List<string>();
        private int currentTrackIndex = 0; // Índice da música atual

        public fMenuPrincipal()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximiza o formulário

            // Configurar o mediaPlayer para ancorar em todos os lados do formulário
            //mediaPlayer.Dock = DockStyle.Fill;

            //// Caminho do vídeo
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Video", "bgMenuPrincipal.mp4");

            //if (File.Exists(path))
            //{
            //    mediaPlayer.URL = path;
            //    mediaPlayer.settings.autoStart = true;
            //    mediaPlayer.uiMode = "none";
            //    mediaPlayer.settings.setMode("loop", true);  // Ativa o loop
            //}


            //MÚSICAS

            playlist.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "Anunciacao.m4a"));
            playlist.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "Anunciacao.m4a"));
            //playlist.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "musica3.mp3"));

            // Verifique se todas as músicas existem
            playlist = playlist.FindAll(File.Exists);

            // Configura o mediaPlayer
            mediaPlayer.settings.autoStart = true;
            mediaPlayer.uiMode = "none";
            mediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;

            // Toca a primeira música
            PlayCurrentTrack();
        }

        private void MediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            
        }

        private void PlayCurrentTrack()
        {
            if (playlist.Count > 0 && currentTrackIndex < playlist.Count)
            {
                mediaPlayer.URL = playlist[currentTrackIndex];
            }
        }

        private void MediaPlayer_PlayStateChange(int NewState)
        {
            // Verifica se a música terminou
            if ((WMPPlayState)NewState == WMPPlayState.wmppsStopped)
            {
                currentTrackIndex++;

                if (currentTrackIndex >= playlist.Count)
                {
                    currentTrackIndex = 0; // Reinicia a playlist quando todas as músicas tocam
                }

                PlayCurrentTrack();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void fMenuPrincipal_Load(object sender, EventArgs e)
        {
            //mediaPlayer.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fEscolherPersonagem nomeDoPersonagem = new fEscolherPersonagem();
            nomeDoPersonagem.ShowDialog();
            this.Close();
        }
    }
}
