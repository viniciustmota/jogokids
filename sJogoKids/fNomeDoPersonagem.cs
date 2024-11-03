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
    public partial class fNomeDoPersonagem : Form
    {
        public fNomeDoPersonagem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fTransicaoSenhaSegura transicaoSenhaSegura = new fTransicaoSenhaSegura();
            transicaoSenhaSegura.ShowDialog();
            this.Close();
        }
    }
}
