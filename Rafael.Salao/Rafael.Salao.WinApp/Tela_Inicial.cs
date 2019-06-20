using System;
using System.IO;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Helper;
using Rafael.Salao.WinApp.Banco;
using Rafael.Salao.WinApp.Funcionarios;
namespace Rafael.Salao.WinApp
{
    public partial class Tela_Inicial : Form
    {
        public DabaseConnection _databaseConnection = new DabaseConnection();
        public Tela_Conexao_Banco TCB = new Tela_Conexao_Banco();
        public Tela_Inicial()
        {
            InializeDatabase();
            InitializeComponent();
         }

        private void InializeDatabase()
        {

            if (!Directory.Exists(@"config"))
            {
                Directory.CreateDirectory(@"config");
            }
            else
            {
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
        }

        private void Remover_funcionario_button_Click(object sender, EventArgs e)
        {
           // FuncionarioDao.RemoverFuncionario(Convert.ToInt32(funcionario_datagrid.Rows[funcionario_datagrid.CurrentRow.Index].Cells[0].Value));
        }

        private void Add_funcionario_button_Click(object sender, EventArgs e)
        {
            Funcionarios_Adicionar_Tela FAT = new Funcionarios_Adicionar_Tela();
            FAT.ShowDialog();
        }

        private void editar_funcionario_button_Click(object sender, EventArgs e)
        {

        }
    }
}
