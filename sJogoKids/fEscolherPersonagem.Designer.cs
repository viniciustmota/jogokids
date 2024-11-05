namespace sJogoKids
{
    partial class fEscolherPersonagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEscolherPersonagem));
            imgProtetorGato1 = new PictureBox();
            imgProtetorAlien = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgProtetorGato1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProtetorAlien).BeginInit();
            SuspendLayout();
            // 
            // imgProtetorGato1
            // 
            imgProtetorGato1.BackColor = Color.Transparent;
            imgProtetorGato1.Cursor = Cursors.Hand;
            imgProtetorGato1.Image = (Image)resources.GetObject("imgProtetorGato1.Image");
            imgProtetorGato1.Location = new Point(256, 268);
            imgProtetorGato1.Name = "imgProtetorGato1";
            imgProtetorGato1.Size = new Size(308, 305);
            imgProtetorGato1.TabIndex = 2;
            imgProtetorGato1.TabStop = false;
            imgProtetorGato1.Click += pictureBox1_Click;
            // 
            // imgProtetorAlien
            // 
            imgProtetorAlien.BackColor = Color.Transparent;
            imgProtetorAlien.Cursor = Cursors.Hand;
            imgProtetorAlien.Image = (Image)resources.GetObject("imgProtetorAlien.Image");
            imgProtetorAlien.Location = new Point(619, 268);
            imgProtetorAlien.Name = "imgProtetorAlien";
            imgProtetorAlien.Size = new Size(308, 305);
            imgProtetorAlien.TabIndex = 3;
            imgProtetorAlien.TabStop = false;
            imgProtetorAlien.Click += imgProtetorAlien_Click;
            // 
            // fEscolherPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1779, 1061);
            Controls.Add(imgProtetorAlien);
            Controls.Add(imgProtetorGato1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fEscolherPersonagem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)imgProtetorGato1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProtetorAlien).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox imgProtetorGato1;
        private PictureBox imgProtetorAlien;
    }
}