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

            //Endereco
            _funcionario.Endereco.Bairro = Convert.ToString(bairro_funcionario_txt.Text);
            _funcionario.Endereco.Rua = Convert.ToString(rua_funcionario_txt.Text);
            _funcionario.Endereco.Numero = Convert.ToString(numero_funcionario_txt.Text);
            _funcionario.Endereco.CEP = Convert.ToString(cep_funcionario_txt.Text);
            _funcionario.Endereco.Complemento = Convert.ToString(complemento_funcionario_txt);

            _funcionarioDao.Adicionar(_funcionario);

        }
    }
}
