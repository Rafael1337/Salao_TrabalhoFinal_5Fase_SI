using System;
using System.IO;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Caixa;
using Rafael.Salao.WinApp.Banco;
using Rafael.Salao.WinApp.Funcionarios;
using Rafael.Salao.WinApp.Caixa;
namespace Rafael.Salao.WinApp
{
    public partial class Tela_Inicial : Form
    {
        public DabaseConnection _databaseConnection = new DabaseConnection();
        public Tela_Conexao_Banco TCB = new Tela_Conexao_Banco();
        public CaixaDao _caixaDao = new CaixaDao();
        public Tela_Inicial()
        {
            InializeDatabase();
            _caixaDao.FirstTimeOpenInitCaixa(_databaseConnection.connection_created);
            InitializeComponent();
         }

        private void InializeDatabase()
        {

            if (!Directory.Exists(@"config"))
            {
                Directory.CreateDirectory(@"config");
            }
          
                if (!File.Exists(@"config\\databaseconfig.xml")){
                    TCB.ShowDialog();
                    InializeDatabase();
                }
                else
                {
                    _databaseConnection.ObterParametrosConnectionString();
                    _databaseConnection.InitializeConnection();
                }
        }

        private void Remover_funcionario_button_Click(object sender, EventArgs e)
        {
            FuncionarioDao funcionario_dao = new FuncionarioDao();
            funcionario_dao.Deletar(Convert.ToInt32(funcionario_datagrid.Rows[funcionario_datagrid.CurrentRow.Index].Cells[0].Value));
        }

        private void Add_funcionario_button_Click(object sender, EventArgs e)
        {
            Funcionarios_Adicionar_Tela FAT = new Funcionarios_Adicionar_Tela();
            FAT.ShowDialog();
        }

        private void editar_funcionario_button_Click(object sender, EventArgs e)
        {

        }

        private void add_saldo_Click(object sender, EventArgs e)
        {
            TelaAdicionar_Saldo TAS = new TelaAdicionar_Saldo();
            TAS.ShowDialog();

        }
    }
}
