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

            // Definir o v�deo para preencher toda a tela
            this.FormBorderStyle = FormBorderStyle.None; // Remove as bordas do formul�rio
            this.WindowState = FormWindowState.Maximized; // Maximiza o formul�rio

            // Configurar o mediaPlayer para ancorar em todos os lados do formul�rio
            mediaPlayer.Dock = DockStyle.Fill;

            // Caminho do v�deo
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
                MessageBox.Show("Arquivo de v�deo n�o encontrado em: " + path);
            }

            // Configurar o evento KeyDown para capturar a tecla Espa�o
            this.KeyPreview = true; // Permite que o formul�rio capture eventos de tecla
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
            // Verifica se a tecla pressionada � Espa�o
            if (e.KeyCode == Keys.Space)
            {
                // Avan�a o v�deo para o final, encerrando a reprodu��o
                mediaPlayer.Ctlcontrols.currentPosition = mediaPlayer.currentMedia.duration;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Verifica se o v�deo terminou
            if (mediaPlayer.playState == WMPPlayState.wmppsStopped)
            {
                // Para o timer
                timer1.Stop();

                // Abre o pr�ximo formul�rio
                fMenuPrincipal menuPrincipal = new fMenuPrincipal();
                menuPrincipal.ShowDialog();

                // Fecha o formul�rio atual
                this.Close();
            }
        }
    }
}
