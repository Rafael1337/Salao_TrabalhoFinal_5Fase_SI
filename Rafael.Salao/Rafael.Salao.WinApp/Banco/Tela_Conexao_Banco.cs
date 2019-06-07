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
            GerarArquivoDeConexao(servidor_txtbox.Text, banco_txtbox.Text, usuario_txtbox.Text, senha_txtbox.Text);
        }

        public void GerarArquivoDeConexao(string servidor, string banco, string usuario, string senha)
        {
            XDocument xdoc = new XDocument();
            string connectionstring = "<database-config><servidor>" + servidor + "</servidor>\n<banco>" + banco + "</banco>\n<usuario>" + usuario + "</usuario>\n <senha>" +senha+ "</senha></database-config>";
            xdoc = XDocument.Parse(connectionstring);
            xdoc.Save(@"config\" + "databaseconfig.xml");
            Close();
        }
    }
}
