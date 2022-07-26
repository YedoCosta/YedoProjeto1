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
    public partial class frmAutenticacao : Form
    {
        public frmAutenticacao()
        {
            InitializeComponent();
        }

        private void butAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Yedo" && txtSenha.Text == "1234")
            {
                //MessageBox.Show("Bem vindo ao Sistema");
                 FrmMenu frm = new FrmMenu();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou Senha invalidos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
