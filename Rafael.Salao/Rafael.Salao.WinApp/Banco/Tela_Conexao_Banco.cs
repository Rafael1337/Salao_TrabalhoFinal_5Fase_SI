using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rafael.Salao.WinApp.Banco
{
    public partial class Tela_Conexao_Banco : Form
    {
        public Tela_Conexao_Banco()
        {
            InitializeComponent();
        }

        private void gravar_database_btn_Click(object sender, EventArgs e)
        {
            Infra.Dados.DabaseConnection DBConnection = new Infra.Dados.DabaseConnection();
            DBConnection.CreateConfigDatabaseFile(servidor_txtbox.Text, banco_txtbox.Text, usuario_txtbox.Text, senha_txtbox.Text);
            Close();
        }
    }
}
