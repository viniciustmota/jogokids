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
            button1 = new Button();
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(309, 158);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(125, 38);
            mediaPlayer.Margin = new Padding(3, 2, 3, 2);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(450, 262);
            mediaPlayer.TabIndex = 3;
            mediaPlayer.Enter += mediaPlayer_Enter;
            // 
            // fMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(mediaPlayer);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fMenuPrincipal";
            Text = "fMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += fMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}