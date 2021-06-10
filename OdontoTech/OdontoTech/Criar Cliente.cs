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
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

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
                cli.cli_bairro = txtbairro.Text;
                cli.cli_telefone = txttelefone.Text;
                cli.cli_cidade = txtcidade.Text;
                cli.cli_endereco = txtendereco.Text;
                cli.cli_numerorua = txtnumero.Text;

                (new ClientesRepositorio()).add(cli);

                MessageBox.Show("Cliente Criado com sucesso.");
                DialogResult resp= MessageBox.Show("Deseja Criar outro Cliente?", "Criar Cliente", MessageBoxButtons.YesNo);
                if(resp == DialogResult.Yes)
                {
                    txtcpf.Text = "";
                    txtnome.Text = "";
                    txtcep.Text = "";
                    txtcnpj.Text = "";
                    txtcidade.Text = "";
                    txttelefone.Text = "";
                    txtbairro.Text = "";
                    txtendereco.Text = "";
                    txtnumero.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível criar o Cliente.");
            }
        }

        private class Enderecos {
            public string cep{ get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
            public string erro { get; set; }
        }



        private void txtcep_TextChanged(object sender, EventArgs e)
        {
            if (txtcep.TextLength == 8) { 
            getcep();
            }
        }

        private async void getcep()
        {
            var URI = "https://viacep.com.br/ws/"+txtcep.Text+"/json/";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var endereco = await response.Content.ReadAsStringAsync();
                        Enderecos json = JsonConvert.DeserializeObject<Enderecos>(endereco);

                        if(json.erro == "True") 
                        {
                            MessageBox.Show("CEP Inexistente");
                        } 
                        else
                        {
                            txtcidade.Text = json.localidade;
                            txtbairro.Text = json.bairro;
                            txtendereco.Text = json.logradouro;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocoreu um erro inexperado");
                    }
                }
            }
        }
    }
}
