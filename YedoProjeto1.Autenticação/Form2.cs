using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YedoProjeto1.Autenticação
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();

            FrmCadCliente frmcc = new FrmCadCliente();
            frmcc.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
