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
                fun.fun_estado = txtestado.Text;
                fun.fun_cidade = txtcidade.Text;
                fun.fun_endereco = txtendereco.Text;
                //fun.fun_numero = txtnumero.Text;

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
                        txtestado.Text = "";
                        txtcidade.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criar o Funcionario.");
            }
        }
    }
}
