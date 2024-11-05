namespace sJogoKids
{
    partial class fNomeDoPersonagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNomeDoPersonagem));
            txtNome = new TextBox();
            btnProximo = new PictureBox();
            imgProtetor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnProximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProtetor).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(222, 235, 244);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(565, 703);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(783, 40);
            txtNome.TabIndex = 1;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.Transparent;
            btnProximo.Cursor = Cursors.Hand;
            btnProximo.Image = (Image)resources.GetObject("btnProximo.Image");
            btnProximo.Location = new Point(1420, 859);
            btnProximo.Margin = new Padding(3, 2, 3, 2);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(381, 123);
            btnProximo.TabIndex = 5;
            btnProximo.TabStop = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // imgProtetor
            // 
            imgProtetor.BackColor = Color.Transparent;
            imgProtetor.Image = (Image)resources.GetObject("imgProtetor.Image");
            imgProtetor.Location = new Point(812, 294);
            imgProtetor.Name = "imgProtetor";
            imgProtetor.Size = new Size(304, 304);
            imgProtetor.SizeMode = PictureBoxSizeMode.AutoSize;
            imgProtetor.TabIndex = 8;
            imgProtetor.TabStop = false;
            // 
            // fNomeDoPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1864, 1033);
            Controls.Add(imgProtetor);
            Controls.Add(btnProximo);
            Controls.Add(txtNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fNomeDoPersonagem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += fNomeDoPersonagem_Load;
            ((System.ComponentModel.ISupportInitialize)btnProximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProtetor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private PictureBox btnProximo;
        private PictureBox imgProtetor;
    }
}