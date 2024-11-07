using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace sJogoKids
{
    public partial class fTransicao : Form
    {
        public fTransicao()
        {
            InitializeComponent();

            // Definir o vídeo para preencher toda a tela
            this.FormBorderStyle = FormBorderStyle.None; // Remove as bordas do formulário
            this.WindowState = FormWindowState.Maximized; // Maximiza o formulário

            // Configurar o mediaPlayer para ancorar em todos os lados do formulário
            mediaPlayer.Dock = DockStyle.Fill;

            // Caminho do vídeo
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Video", "Introducao.mp4");

            if (File.Exists(path))
            {
                mediaPlayer.URL = path;
                mediaPlayer.settings.autoStart = true;
                mediaPlayer.uiMode = "none";

                // Inicializa o Timer
                
                timer1.Interval = 1000; // Verifica a cada segundo
                timer1.Tick += Timer_Tick; // Adiciona o evento Tick
                timer1.Start(); // Inicia o timer
            }
            else
            {
                MessageBox.Show("Arquivo de vídeo não encontrado em: " + path);
            }

            // Configurar o evento KeyDown para capturar a tecla Espaço
            this.KeyPreview = true; // Permite que o formulário capture eventos de tecla
            this.KeyDown += Form_KeyDown;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void fTelaInicial_Load(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
            
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Espaço
            if (e.KeyCode == Keys.Space)
            {
                // Avança o vídeo para o final, encerrando a reprodução
                mediaPlayer.Ctlcontrols.currentPosition = mediaPlayer.currentMedia.duration;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Verifica se o vídeo terminou
            if (mediaPlayer.playState == WMPPlayState.wmppsStopped)
            {
                // Para o timer
                timer1.Stop();

                // Abre o próximo formulário
                fMenuPrincipal menuPrincipal = new fMenuPrincipal();
                menuPrincipal.ShowDialog();

                // Fecha o formulário atual
                this.Close();
            }
        }
    }
}
