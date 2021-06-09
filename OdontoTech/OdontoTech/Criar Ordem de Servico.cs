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
    public partial class Criar_Ordem_de_Servico : Form
    {
        public Criar_Ordem_de_Servico()
        {
            InitializeComponent();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Ordem_Servico os = new Ordem_Servico();
            try
            {
                Clientes cli = new Clientes();
                cli = new ClientesRepositorio().get(txtcpf.Text);
                if (cli != null)
                {
                    os.Clientes = cli;
                    os.cod_clientes = cli.cli_codigo;
                    os.ord_dataderecebimento = dtpdatarecebimento.Value;
                    os.ord_descricao = txtdescricao.Text;
                    os.ord_quantidade = int.Parse(txtqtde.Text);
                    os.ord_valor = decimal.Parse(txtvalor.Text);
                    
                    if (new OrdemServicoRepositorio().add(os))
                    {
                        new PecasRepositorio().add(new Pecas()
                        {
                            cod_ordemservico = os.ord_codigo,
                            pec_nome = txtpeca.Text,
                        });

                        MessageBox.Show("Ordem de Serviço Criada com Sucesso.");
                        DialogResult resp = MessageBox.Show("Deseja Criar outra Ordem de Serviço?", "Criar Ordem de Serviço", MessageBoxButtons.YesNo);
                        if (resp == DialogResult.Yes)
                        {
                            label0.Text = "";
                            txtdescricao.Text = "";
                            txtnomecliente.Text = "";
                            txtpeca.Text = "";
                            txtqtde.Text = "";
                            txtvalor.Text = "";
                            txtcpf.Text = "";
                            dtpdatarecebimento.Value = DateTime.Now;
                            txtcpf.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível criar a Ordem de Serviço.");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado, se necessário crie um novo cliente.");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void txtcpf_Leave(object sender, EventArgs e)
        {
            try
            {
                Clientes cli = new Clientes();
                cli = new ClientesRepositorio().get(txtcpf.Text);
                txtnomecliente.Text = cli.cli_nome;
            }
            catch (Exception ex)
            {
                txtnomecliente.Text = "";
                MessageBox.Show("Cliente não encontrado, se necessário crie um novo cliente.");
            }
        }

        private void txtcpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtcpf.Text.Length>9)
            {
                try
                {
                    Clientes cli = new Clientes();
                    cli = new ClientesRepositorio().get(txtcpf.Text);
                    txtnomecliente.Text = cli.cli_nome;
                }
                catch (Exception ex)
                {
                    txtnomecliente.Text = "";
                    MessageBox.Show("Cliente não encontrado, se necessário crie um novo cliente.");
                } 
            }
        }

        private void btncriarcliente_Click(object sender, EventArgs e)
        {
            Criar_Cliente Frm = new Criar_Cliente();
            this.Hide();
            Frm.ShowDialog();
            Frm.Dispose();
            this.Show();
        }
    }
}
