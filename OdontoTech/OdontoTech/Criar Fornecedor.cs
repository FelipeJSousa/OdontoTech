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
    public partial class Criar_Fornecedor : Form
    {
        public Criar_Fornecedor()
        {
            InitializeComponent();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            try
            {
                forn.for_cnpj = txtcnpj.Text;
                forn.for_cpf = txtcpf.Text;
                forn.for_email = txtemail.Text;
                forn.for_endereco = txtendereco.Text;
                forn.for_racaosociais = txtrazaosocial.Text;
                forn.for_telefone = txttelefone.Text;

                if (new FornecedorRepositorio().add(forn))
                {
                    MessageBox.Show("Fornecedor Criado com sucesso.");
                    DialogResult resp = MessageBox.Show("Deseja Criar outro Fornecedor?", "Criar Fornecedor", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        txtcpf.Text = "";
                        txtcep.Text = "";
                        txtcnpj.Text = "";
                        txtrazaosocial.Text = "";
                        txtestado.Text = "";
                        txttelefone.Text = "";
                        txtcidade.Text = "";
                        txtendereco.Text = "";
                        txtnumero.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível criar o Fornecedor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criar o Fornecedor.");
            }
        }
    }
}
