using System;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.WinApp.Banco;
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
            _databaseConnection.InitializeConnection();
            if (!_databaseConnection.connection_valid)
            {
                TCB.ShowDialog();
            }
            InializeDatabase();
        }

        private void remover_funcionario_button_Click(object sender, EventArgs e)
        {
        }

        private void add_funcionario_button_Click(object sender, EventArgs e)
        {

        }

        private void editar_funcionario_button_Click(object sender, EventArgs e)
        {

        }
    }
}
