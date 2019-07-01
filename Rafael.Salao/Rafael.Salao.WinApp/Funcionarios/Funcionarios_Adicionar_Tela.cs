using System;
using System.Windows.Forms;
using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados.Funcionario;

namespace Rafael.Salao.WinApp.Funcionarios
{
    public partial class Funcionarios_Adicionar_Tela : Form
    {
        public FuncionarioDao _funcionarioDao = new FuncionarioDao();
        public Funcionarios_Adicionar_Tela()
        {
            InitializeComponent();
        }

        private void gravar_funcionar_button_Click(object sender, EventArgs e)
        {
            Funcionario _funcionario = new Funcionario();

            _funcionario.Nome = nome_funcionario_txt.Text;
            _funcionario.Telefone = Convert.ToDouble(telefone_funcionario_txt.Text);
            _funcionario.Idade = Convert.ToInt32(idade_funcionario_txt.Text);
            _funcionario.RG = Convert.ToDouble(rg_funcionario_txt.Text);
            _funcionario.CPF = Convert.ToDouble(cpf_funcionario_txt.Text);
            _funcionario.Cabelo = cabelo_box_funcionario.Checked;
            _funcionario.Depilacao = depilacao_box_funcionario.Checked;
            _funcionario.Unha = unha_box_funcionario.Checked;

            _funcionarioDao.Adicionar(_funcionario);

            Close();

            Tela_Inicial TI = new Tela_Inicial();
            TI.Show();
        }
    }
}
