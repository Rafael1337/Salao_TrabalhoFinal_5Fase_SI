using System;
using System.IO;
using System.Windows.Forms;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Caixa;
using Rafael.Salao.WinApp.Banco;
using Rafael.Salao.WinApp.Funcionarios;
using Rafael.Salao.WinApp.Caixa;
using Rafael.Salao.WinApp.Agenda;
using Rafael.Salao.Infra.Dados.Servicos;
using System.Data;
using System.Data.SqlClient;

namespace Rafael.Salao.WinApp
{
    public partial class Tela_Inicial : Form
    {
        public DabaseConnection _databaseConnection = new DabaseConnection();
        public Tela_Conexao_Banco TCB = new Tela_Conexao_Banco();
        public CaixaDao _caixaDao = new CaixaDao();
        public ServicosDao _servicosDao = new ServicosDao();
        public FuncionarioDao _funcionarioDao = new FuncionarioDao();

        public Tela_Inicial()
        {
            InializeDatabase();
            InitializeComponent();
            CarregarContextosDeTelas();
        }

        public void CarregarContextosDeTelas()
        {
            _servicosDao.VerifyAlredyExistServices();
            _caixaDao.FirstTimeOpenInitCaixa(DabaseConnection.connection_created);
            saldo_atual_txtbox.Text = _caixaDao.EscreveSaldoAtual(DabaseConnection.connection_created).ToString();
            PopulateGrids();
        }

        private void PopulateGrids()
        {
            PopulateFuncionarioGrid();
            PopulateAgendaGrid();
        }

        private void PopulateFuncionarioGrid()
        {
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(new SqlCommand("select * from tbfuncionario", DabaseConnection.connection_created));

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            funcionario_datagrid.DataSource = dtRecord;
        }

        private void PopulateAgendaGrid()
        {
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(new SqlCommand("select NOME_CLIENTE, DATA, HORARIO from tbagenda", DabaseConnection.connection_created));
            
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            agenda_datagrid.DataSource = dtRecord;
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
            Hide();
            TelaAdicionar_Saldo TAS = new TelaAdicionar_Saldo();
            TAS.ShowDialog();

        }

        private void adicionar_horario_agenda_button_Click(object sender, EventArgs e)
        {
            Agenda_Adicionar_Tela AAT = new Agenda_Adicionar_Tela();
            AAT.Show();
        }

        private void fechar_caixa_Click(object sender, EventArgs e)
        {
            _caixaDao.FecharCaixa();
        }
    }
}
