using System;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Caixa;
using Rafael.Salao.WinApp;

namespace Rafael.Salao.WinApp.Caixa
{
    public partial class TelaAdicionar_Saldo : Form
    {
        public DabaseConnection databaseConnection = new DabaseConnection();
        public CaixaDao _caixaDao = new CaixaDao();
        public Tela_Inicial TI = new Tela_Inicial();
        public TelaAdicionar_Saldo()
        {
            InitializeComponent();
        }

        private void add_saldo_btn_Click(object sender, EventArgs e)
        {
            _caixaDao.AdicionarSaldo(Convert.ToDouble(saldo_adicionar_txtbox.Text), DabaseConnection.connection_created);
            double valor1 = Convert.ToDouble(TI.saldo_atual_txtbox.Text);
            double valor2 = Convert.ToDouble(saldo_adicionar_txtbox.Text);
            double resultado = valor1 + valor2;
            TI.saldo_atual_txtbox.Text = resultado.ToString();
            Close();
            TI.Show();
        }
    }
}
