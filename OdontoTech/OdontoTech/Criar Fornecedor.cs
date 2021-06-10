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
                forn.for_racaosociais = txtrazaosocial.Text;
                forn.for_cpf = txtcpf.Text;
                forn.for_cnpj = txtcnpj.Text;
                forn.for_email = txtemail.Text;
                forn.for_telefone = txttelefone.Text;
                forn.for_cep = txtcep.Text;
                forn.for_cidade = txtcidade.Text;
                forn.for_bairro = txtbairro.Text;
                forn.for_endereco = txtendereco.Text;
                forn.for_numero = txtnumero.Text;

                (new FornecedorRepositorio()).add(forn);
                MessageBox.Show("Fornecedor Criado com sucesso.");
                DialogResult resp = MessageBox.Show("Deseja Criar outro Fornecedor?", "Criar Fornecedor", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    txtcpf.Text = "";
                    txtcep.Text = "";
                    txtcnpj.Text = "";
                    txtrazaosocial.Text = "";
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
                MessageBox.Show("Não foi possível criar o Fornecedor.");
            }
        }
        private class Enderecos
        {
            public string cep { get; set; }
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
            if (txtcep.TextLength == 8)
            {
                getcep();
            }
        }

        private async void getcep()
        {
            var URI = "https://viacep.com.br/ws/" + txtcep.Text + "/json/";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var endereco = await response.Content.ReadAsStringAsync();
                        Enderecos json = JsonConvert.DeserializeObject<Enderecos>(endereco);

                        if (json.erro == "True")
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
