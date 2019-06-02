using System;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;

namespace Rafael.Salao.WinApp
{
    public partial class Tela_Inicial : Form
    {
        public DabaseConnection _databaseConnection;
        public Tela_Inicial()
        {
            InitializeComponent();
            _databaseConnection.InitializeConnection();
        }
      

        private void remover_funcionario_button_Click(object sender, EventArgs e)
        {

        }
    }
}
