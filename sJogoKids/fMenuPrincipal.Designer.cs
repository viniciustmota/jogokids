namespace sJogoKids
{
    partial class fMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenuPrincipal));
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            btnProximo = new PictureBox();
            btnJogar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnJogar).BeginInit();
            SuspendLayout();
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(608, 55);
            mediaPlayer.Margin = new Padding(3, 2, 3, 2);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(450, 262);
            mediaPlayer.TabIndex = 3;
            mediaPlayer.Visible = false;
            mediaPlayer.Enter += mediaPlayer_Enter;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.Transparent;
            btnProximo.Cursor = Cursors.Hand;
            btnProximo.Image = (Image)resources.GetObject("btnProximo.Image");
            btnProximo.Location = new Point(266, 546);
            btnProximo.Margin = new Padding(3, 2, 3, 2);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(284, 78);
            btnProximo.TabIndex = 6;
            btnProximo.TabStop = false;
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.Transparent;
            btnJogar.Cursor = Cursors.Hand;
            btnJogar.Image = (Image)resources.GetObject("btnJogar.Image");
            btnJogar.Location = new Point(266, 458);
            btnJogar.Margin = new Padding(3, 2, 3, 2);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(284, 75);
            btnJogar.TabIndex = 7;
            btnJogar.TabStop = false;
            btnJogar.Click += pictureBox1_Click;
            // 
            // fMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1451, 749);
            Controls.Add(btnJogar);
            Controls.Add(btnProximo);
            Controls.Add(mediaPlayer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fMenuPrincipal";
            Text = "fMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += fMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnJogar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private PictureBox btnProximo;
        private PictureBox btnJogar;
    }
}