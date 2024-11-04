
namespace sJogoKids
{
    partial class fTransicao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTransicao));
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(0, -1);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(450, 262);
            mediaPlayer.TabIndex = 1;
            mediaPlayer.Enter += mediaPlayer_Enter;
            // 
            // timer1
            // 

            // 
            // fTransicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 1055);
            Controls.Add(mediaPlayer);
            Name = "fTransicao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Robo Protetor: A missão";
            WindowState = FormWindowState.Maximized;
            Load += fTelaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Timer timer1;
        private EventHandler timer1_Tick;
    }
}
