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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ListarOrdensdeServico()
        {
            List<Ordem_Servico> lista = new OrdemServicoRepositorio().getAll();

            dglistagem.DataSource = lista;

            dglistagem.Columns[7].Visible = false;
            dglistagem.Columns[8].Visible = false;

            dglistagem.Columns[0].HeaderText = "Codigo";
            dglistagem.Columns[1].HeaderText = "Data de Recebimento";
            dglistagem.Columns[2].HeaderText = "Data de Entrega";
            dglistagem.Columns[3].HeaderText = "Quantidade";
            dglistagem.Columns[4].HeaderText = "Descrição";
            dglistagem.Columns[5].HeaderText = "Valor";
            dglistagem.Columns[6].HeaderText = "Codigo do Clientes";
        }

        private void ListarClientes()
        {
            List<Clientes> lista = new ClientesRepositorio().getAll();

            dglistagem.DataSource = lista;

            dglistagem.Columns[10].Visible = false;
            dglistagem.Columns[11].Visible = false;

            dglistagem.Columns[0].HeaderText = "Codigo";
            dglistagem.Columns[1].HeaderText = "Nome";
            dglistagem.Columns[2].HeaderText = "Telefone";
            dglistagem.Columns[3].HeaderText = "CPF";
            dglistagem.Columns[4].HeaderText = "CNPJ";
            dglistagem.Columns[5].HeaderText = "Endereço";
            dglistagem.Columns[6].HeaderText = "Numero";
            dglistagem.Columns[7].HeaderText = "Cidade";
            dglistagem.Columns[8].HeaderText = "Estado";
            dglistagem.Columns[9].HeaderText = "CEP";



        }

        private void ListarFuncionarios()
        {
            List<Funcionarios> lista = new FuncionariosRepositorio().getAll();

            dglistagem.DataSource = lista;


            dglistagem.Columns[0].HeaderText = "Codigo";
            dglistagem.Columns[1].HeaderText = "Nome";
            dglistagem.Columns[2].HeaderText = "Telefone";
            dglistagem.Columns[3].HeaderText = "CPF";
            dglistagem.Columns[4].HeaderText = "Endereço";
            dglistagem.Columns[5].HeaderText = "Cidade";
            dglistagem.Columns[6].HeaderText = "Estado";
            dglistagem.Columns[7].HeaderText = "Email";
            dglistagem.Columns[8].HeaderText = "Cargo";
            dglistagem.Columns[9].HeaderText = "Salario";
            dglistagem.Columns[10].HeaderText = "CEP";
            dglistagem.Columns[11].HeaderText = "Numero da Casa";
        }

        private void ListarFornecedor()
        {
            List<Fornecedor> lista = new FornecedorRepositorio().getAll();

            dglistagem.DataSource = lista;


            dglistagem.Columns[0].HeaderText = "Codigo";
            dglistagem.Columns[1].HeaderText = "Ração Social";
            dglistagem.Columns[2].HeaderText = "CNPJ";
            dglistagem.Columns[3].HeaderText = "CPF";
            dglistagem.Columns[4].HeaderText = "Endereço";
            dglistagem.Columns[5].HeaderText = "Email";
            dglistagem.Columns[6].HeaderText = "Telefone";
            dglistagem.Columns[7].HeaderText = "CEP";
            dglistagem.Columns[8].HeaderText = "Estado";
            dglistagem.Columns[9].HeaderText = "Cidade";
            dglistagem.Columns[10].HeaderText = "Numero da Casa";
        }
        private void ListarUsuarios()
        {
            List<Usuario> lista = new UsuarioRepositorio().getAll();

            dglistagem.DataSource = lista;

            dglistagem.Columns[0].HeaderText = "Codigo";
            dglistagem.Columns[1].HeaderText = "Nome";
            dglistagem.Columns[2].HeaderText = "Senha (Criptografada)";

        }
        private void ListarPecas()
        {
            List<Pecas> lista = new PecasRepositorio().getAll();

            dglistagem.DataSource = lista;

            dglistagem.Columns[0].HeaderText = "Codigo";
            dglistagem.Columns[1].HeaderText = "Nome";
            dglistagem.Columns[2].HeaderText = "Codigo Ordem de Serviço";

            dglistagem.Columns[3].Visible = false;
        }

        private void Listagem_Load(object sender, EventArgs e)
        {
            cbLista.Items.Add("Clientes");
            cbLista.Items.Add("Funcionarios");
            cbLista.Items.Add("Fornecedores");
            cbLista.Items.Add("Usuarios");
            cbLista.Items.Add("Ordens de Serviço");
            cbLista.Items.Add("Peças");
            cbLista.SelectedIndex = 4;

            ListarOrdensdeServico();
        }

        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLista.SelectedIndex)
            {
                case 0:
                    ListarClientes();
                    break;
                case 1:
                    ListarFuncionarios();
                    break;
                case 2:
                    ListarFornecedor();
                    break;
                case 3:
                    ListarUsuarios();
                    break;
                case 4:
                    ListarOrdensdeServico();
                    break;
                case 5:
                    ListarPecas();
                    break;
                default:
                    MessageBox.Show("Ocorreu um erro inesperado");
                    break;
            }
        }
    }
}
