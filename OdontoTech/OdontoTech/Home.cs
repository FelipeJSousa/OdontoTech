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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            sessionUsuario.Text = $"Bem-vindo, {FrmGlobal.usuario}!";
        }

        private void btncriarusuario_Click(object sender, EventArgs e)
        {
            Criar_Usuario Frm = new Criar_Usuario();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btncriarordem_Click(object sender, EventArgs e)
        {
            Criar_Ordem_de_Servico Frm = new Criar_Ordem_de_Servico();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btnfinalizarordem_Click(object sender, EventArgs e)
        {
            Finalizar_Ordem_de_Servico Frm = new Finalizar_Ordem_de_Servico();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btncriarfornecedor_Click(object sender, EventArgs e)
        {
            Criar_Fornecedor Frm = new Criar_Fornecedor();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btncriarfuncionario_Click(object sender, EventArgs e)
        {
            Criar_Funcionario Frm = new Criar_Funcionario();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btncriarcliente_Click(object sender, EventArgs e)
        {
            Criar_Cliente Frm = new Criar_Cliente();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btncontrolefinanceiro_Click(object sender, EventArgs e)
        {
            Controle Frm = new Controle();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }

        private void btnlistagem_Click(object sender, EventArgs e)
        {
            Listagem Frm = new Listagem();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }
    }
}
