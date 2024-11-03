namespace sJogoKids
{
    partial class fSenhaSegura
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSenhaSegura));
            txtSenha = new TextBox();
            txtRepetirSenha = new TextBox();
            btnAjuda = new PictureBox();
            btnProximo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            mensagemDeAjuda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnAjuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mensagemDeAjuda).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(230, 225, 254);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(561, 478);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(789, 50);
            txtSenha.TabIndex = 0;
            // 
            // txtRepetirSenha
            // 
            txtRepetirSenha.BackColor = Color.FromArgb(230, 225, 254);
            txtRepetirSenha.BorderStyle = BorderStyle.None;
            txtRepetirSenha.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepetirSenha.Location = new Point(561, 710);
            txtRepetirSenha.Name = "txtRepetirSenha";
            txtRepetirSenha.Size = new Size(789, 50);
            txtRepetirSenha.TabIndex = 1;
            // 
            // btnAjuda
            // 
            btnAjuda.BackColor = Color.Transparent;
            btnAjuda.Cursor = Cursors.Hand;
            btnAjuda.Image = (Image)resources.GetObject("btnAjuda.Image");
            btnAjuda.Location = new Point(1665, 857);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(136, 145);
            btnAjuda.TabIndex = 3;
            btnAjuda.TabStop = false;
            btnAjuda.Click += btnAjuda_Click_1;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.Transparent;
            btnProximo.Cursor = Cursors.Hand;
            btnProximo.Image = (Image)resources.GetObject("btnProximo.Image");
            btnProximo.Location = new Point(541, 857);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(843, 145);
            btnProximo.TabIndex = 4;
            btnProximo.TabStop = false;
            btnProximo.Click += pictureBox2_Click;
            // 
            // mensagemDeAjuda
            // 
            mensagemDeAjuda.BackColor = Color.Transparent;
            mensagemDeAjuda.Cursor = Cursors.Hand;
            mensagemDeAjuda.Image = (Image)resources.GetObject("mensagemDeAjuda.Image");
            mensagemDeAjuda.Location = new Point(1396, 351);
            mensagemDeAjuda.Name = "mensagemDeAjuda";
            mensagemDeAjuda.Size = new Size(447, 489);
            mensagemDeAjuda.SizeMode = PictureBoxSizeMode.AutoSize;
            mensagemDeAjuda.TabIndex = 5;
            mensagemDeAjuda.TabStop = false;
            mensagemDeAjuda.Visible = false;
            mensagemDeAjuda.Click += mensagemDeAjuda_Click_1;
            // 
            // fSenhaSegura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1892, 1041);
            Controls.Add(mensagemDeAjuda);
            Controls.Add(btnProximo);
            Controls.Add(btnAjuda);
            Controls.Add(txtRepetirSenha);
            Controls.Add(txtSenha);
            Name = "fSenhaSegura";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += fSenhaSegura_Load;
            ((System.ComponentModel.ISupportInitialize)btnAjuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)mensagemDeAjuda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtRepetirSenha;
        private PictureBox btnAjuda;
        private PictureBox btnProximo;
        private System.Windows.Forms.Timer timer1;
        private PictureBox mensagemDeAjuda;
    }
}