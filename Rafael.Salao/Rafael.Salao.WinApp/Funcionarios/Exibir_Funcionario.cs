using Rafael.Salao.Infra.Dados.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafael.Salao.WinApp.Funcionarios
{
    public partial class Exibir_Funcionario : Form
    {

        public Dominio.Funcionario funcionario = new Dominio.Funcionario();
        public FuncionarioDao _funcionarioDao = new FuncionarioDao();
        public Exibir_Funcionario(Dominio.Funcionario funcionario_exibir)
        {
            funcionario = funcionario_exibir;
            InitializeComponent();
            PopulateFields();
        }
        private void PopulateFields()
        {
            nome_funcionario_txt.Text = funcionario.Nome;
            telefone_funcionario_txt.Text = funcionario.Telefone.ToString();
            cpf_funcionario_txt.Text = funcionario.CPF.ToString();
            rg_funcionario_txt.Text = funcionario.RG.ToString();
            idade_funcionario_txt.Text = funcionario.Idade.ToString();
            unha_box_funcionario.Checked = funcionario.Unha;
            cabelo_box_funcionario.Checked = funcionario.Cabelo;
            depilacao_box_funcionario.Checked = funcionario.Depilacao;
        }

        private void retornar_tela_inicial_Click(object sender, EventArgs e)
        {
            Close();
            Tela_Inicial TI = new Tela_Inicial();
            TI.Show();
        }
    }
}
