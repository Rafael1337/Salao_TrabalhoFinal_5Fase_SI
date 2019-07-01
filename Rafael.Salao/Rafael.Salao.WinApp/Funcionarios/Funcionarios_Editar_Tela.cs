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
    public partial class Funcionarios_Editar_Tela : Form
    {
        public Dominio.Funcionario funcionario = new Dominio.Funcionario();
        public FuncionarioDao _funcionarioDao = new FuncionarioDao();

        public Funcionarios_Editar_Tela(Dominio.Funcionario funcionario_edit)
        {
            funcionario = funcionario_edit;
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

        private void editar_funcionar_button_Click(object sender, EventArgs e)
        {
            Dominio.Funcionario funcionarioEditado = _funcionarioDao.BuscarPorId(funcionario.Id);

            funcionarioEditado.Nome = nome_funcionario_txt.Text;
            funcionarioEditado.Telefone = telefone_funcionario_txt.Text;
            funcionarioEditado.CPF = Convert.ToDouble(cpf_funcionario_txt.Text);
            funcionarioEditado.RG = Convert.ToDouble(rg_funcionario_txt.Text);
            funcionarioEditado.Idade = Convert.ToInt32(idade_funcionario_txt.Text);
            funcionarioEditado.Unha = unha_box_funcionario.Checked;
            funcionarioEditado.Cabelo = cabelo_box_funcionario.Checked;
            funcionarioEditado.Depilacao = depilacao_box_funcionario.Checked;

            _funcionarioDao.Editar(funcionarioEditado);

            Close();

            Tela_Inicial TI = new Tela_Inicial();
            TI.Show();
        }
    }
}
