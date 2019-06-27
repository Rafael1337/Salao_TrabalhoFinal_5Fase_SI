using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Caixa;

namespace Rafael.Salao.WinApp.Caixa
{
    public partial class TelaAdicionar_Saldo : Form
    {
        public DabaseConnection databaseConnection = new DabaseConnection();
        public CaixaDao _caixaDao = new CaixaDao();
        public TelaAdicionar_Saldo()
        {
            InitializeComponent();
        }

        private void add_saldo_btn_Click(object sender, EventArgs e)
        {
            _caixaDao.AdicionarSaldo(Convert.ToDouble(saldo_adicionar_txtbox.Text), DabaseConnection.connection_created);
        }
    }
}
