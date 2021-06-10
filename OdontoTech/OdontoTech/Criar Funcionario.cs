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
    public partial class Criar_Funcionario : Form
    {
        public Criar_Funcionario()
        {
            InitializeComponent();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Funcionarios fun = new Funcionarios();
            try
            {
                fun.fun_nome = txtnome.Text;
                fun.fun_cpf = txtcpf.Text;
                fun.fun_telefone = txttelefone.Text;
                fun.fun_email = txtemail.Text;
                fun.fun_cargo = txtcargo.Text;
                fun.fun_salario = decimal.Parse(txtsalario.Text);
                fun.fun_cep = txtcep.Text;
                fun.fun_cidade = txtcidade.Text;
                fun.fun_bairro = txtbairro.Text;
                fun.fun_endereco = txtendereco.Text;
                fun.fun_numero = txtnumero.Text;

                if (new FuncionariosRepositorio().add(fun))
                {
                    MessageBox.Show("Funcionario Criado com sucesso.");
                    DialogResult resp = MessageBox.Show("Deseja Criar outro Funcionario?", "Criar Funcionario", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        txtnome.Text = "";
                        txtcpf.Text = "";
                        txttelefone.Text = "";
                        txtcep.Text = "";
                        txtemail.Text = "";
                        txtcargo.Text = "";
                        txtsalario.Text = "";
                        txtcidade.Text = "";
                        txtbairro.Text = "";
                        txttelefone.Text = "";
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
                    MessageBox.Show("Não foi possível criar o Funcionario.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível criar o Funcionario.");
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
