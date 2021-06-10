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
    public partial class Finalizar_Ordem_de_Servico : Form
    {
        public Finalizar_Ordem_de_Servico()
        {
            InitializeComponent();
        }

        private void Finalizar_Ordem_de_Servico_Load(object sender, EventArgs e)
        {
            List<vw_ordemcomdatanulu> lista = new vw_ordemcomdatanuluRepositorio().getAll();

            dgordens.DataSource = lista;

            dgordens.Columns[0].HeaderText = "Codigo";
            dgordens.Columns[1].HeaderText = "Data de Recebimento";
            dgordens.Columns[2].HeaderText = "Data de Entrega";
            dgordens.Columns[3].HeaderText = "Descrição";
            dgordens.Columns[4].HeaderText = "Valor";
            dgordens.Columns[5].Visible = false;
            dgordens.Columns[6].HeaderText = "Nome da Peça";
            dgordens.Columns[7].HeaderText = "Nome do Cliente";
        }

        private void txtpeca_TextChanged(object sender, EventArgs e)
        {
            List<vw_ordemcomdatanulu> lista = new vw_ordemcomdatanuluRepositorio().procurarCliente(txtpeca.Text);

            dgordens.DataSource = lista;
        }

        private void dgordens_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = (int)dgordens.Rows[e.RowIndex].Cells[0].Value;

            try
            {
                Ordem_Servico ordem = new OrdemServicoRepositorio().get(codigo);
                ordem.ord_dataentrega = DateTime.Now;

                (new OrdemServicoRepositorio()).edit(ordem);

                MessageBox.Show("Ordem de Serviço finalizado com Sucesso");

                List<vw_ordemcomdatanulu> lista = new vw_ordemcomdatanuluRepositorio().procurarCliente(txtpeca.Text);
                dgordens.DataSource = lista;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro Inesperado");
                throw;
            }


        }
    }
}
