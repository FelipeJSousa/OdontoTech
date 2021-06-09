using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoTech
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtuser.Focus();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtuser.Text) && !String.IsNullOrEmpty(txtsenha.Text))
            {
                Usuario user = new UsuarioRepositorio().validarLogin(txtuser.Text, txtsenha.Text);
                if (user.Usu_codigos != null)
                {
                    FrmGlobal.usuario = user.usu_nome;
                    txtuser.Text = "";
                    txtsenha.Text = "";
                    Home frm = new Home();
                    this.Hide();
                    frm.ShowDialog();
                    frm.Dispose();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuário/senha inválidos!");
                }
            }
            else
            {
                MessageBox.Show("Usuário/senha inválidos!");
            }
        }
    }
}
