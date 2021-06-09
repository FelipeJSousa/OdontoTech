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
    public partial class Criar_Cliente : Form
    {
        public Criar_Cliente()
        {
            InitializeComponent();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            try
            {
                cli.cli_cpf = txtcpf.Text;
                cli.cli_nome = txtnome.Text;
                cli.cli_cep = txtcep.Text;
                cli.cli_cnpj = txtcnpj.Text;
                cli.cli_estado = txtestado.Text;
                cli.cli_telefone = txttelefone.Text;
                cli.cli_cidade = txtcidade.Text;
                cli.cli_endereco = txtendereco.Text;
                cli.cli_numerorua = txtnumero.Text;

                if (new ClientesRepositorio().add(cli))
                {
                    MessageBox.Show("Cliente Criado com sucesso.");
                    DialogResult resp= MessageBox.Show("Deseja Criar outro Cliente?", "Criar Cliente", MessageBoxButtons.YesNo);
                    if(resp == DialogResult.Yes)
                    {
                        txtcpf.Text = "";
                        txtnome.Text = "";
                        txtcep.Text = "";
                        txtcnpj.Text = "";
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
                    MessageBox.Show("Não foi possível criar o Cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criar o Cliente.");
            }
        }
    }
}
