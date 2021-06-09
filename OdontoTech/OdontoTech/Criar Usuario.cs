using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;

namespace OdontoTech
{
    public partial class Criar_Usuario : Form
    {
        public Criar_Usuario()
        {
            InitializeComponent();
        }

        private void Criar_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if(!String.IsNullOrEmpty(txtuser.Text) && !String.IsNullOrEmpty(txtsenha.Text))
            {
                user.usu_nome = txtuser.Text;
                user.usu_senha = new UsuarioRepositorio().Encrypt(txtsenha.Text);
                if(new UsuarioRepositorio().add(user))
                {
                    MessageBox.Show("Usuário criado com sucesso!");
                    txtuser.Text = "";
                    txtsenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Não foi possível criar o Usuário!");
                }
            }
        }
    }
}
