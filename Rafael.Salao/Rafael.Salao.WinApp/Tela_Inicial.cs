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
using System.Collections.Generic;
using Rafael.Salao.Infra.Dados.Agenda;

namespace Rafael.Salao.WinApp
{
    public partial class Tela_Inicial : Form
    {
        public DabaseConnection _databaseConnection = new DabaseConnection();
        public Tela_Conexao_Banco TCB = new Tela_Conexao_Banco();

        public CaixaDao _caixaDao = new CaixaDao();
        public ServicosDao _servicosDao = new ServicosDao();
        public FuncionarioDao _funcionarioDao = new FuncionarioDao();
        public AgendaDao _agendaDao = new AgendaDao();

        public DataTable dtRecordFuncionario = new DataTable();
        public DataTable dtRecordAgenda = new DataTable();
        public BindingSource bindingSource1 = new BindingSource();


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

        public void PopulateGrids()
        {
            PopulateFuncionarioGrid();
            PopulateAgendaGrid();
        }

        public void PopulateFuncionarioGrid()
        {
            SqlDataAdapter sqlDataAdapFuncionario = new SqlDataAdapter(new SqlCommand("select * from tbfuncionario", DabaseConnection.connection_created));
            sqlDataAdapFuncionario.Fill(dtRecordFuncionario);
            funcionario_datagrid.DataSource = dtRecordFuncionario;
        }

        private void PopulateAgendaGrid()
        {
            SqlDataAdapter sqlDataAdapAgenda = new SqlDataAdapter(new SqlCommand("SELECT ID, HORARIO, DATA, NOME_CLIENTE, TELEFONE FROM TBAGENDA", DabaseConnection.connection_created));

            sqlDataAdapAgenda.Fill(dtRecordAgenda);
            agenda_datagrid.DataSource = dtRecordAgenda;
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
            IList<Dominio.Funcionario> list_funcionario;
            _funcionarioDao.Deletar(Convert.ToInt32(funcionario_datagrid.Rows[funcionario_datagrid.CurrentRow.Index].Cells[0].Value));
            list_funcionario = _funcionarioDao.BuscarTodos();

            funcionario_datagrid.DataSource = list_funcionario;
            funcionario_datagrid.Update();
        }

        private void Add_funcionario_button_Click(object sender, EventArgs e)
        {
            Hide();
            Funcionarios_Adicionar_Tela FAT = new Funcionarios_Adicionar_Tela();
            FAT.ShowDialog();
        }

        private void editar_funcionario_button_Click(object sender, EventArgs e)
        {
            Hide();
            Dominio.Funcionario funcionario_edit = _funcionarioDao.BuscarPorId(Convert.ToInt32(funcionario_datagrid.Rows[funcionario_datagrid.CurrentRow.Index].Cells[0].Value));

            Funcionarios_Editar_Tela FET = new Funcionarios_Editar_Tela(funcionario_edit);
            FET.Show();
        }

        private void add_saldo_Click(object sender, EventArgs e)
        {
            Hide();
            TelaAdicionar_Saldo TAS = new TelaAdicionar_Saldo();
            TAS.ShowDialog();

        }

        private void adicionar_horario_agenda_button_Click(object sender, EventArgs e)
        {
            Hide();
            Agenda_Adicionar_Tela AAT = new Agenda_Adicionar_Tela();
            AAT.Show();
        }

        private void fechar_caixa_Click(object sender, EventArgs e)
        {
            _caixaDao.FecharCaixa();
        }

        private void remover_horario_agenda_button_Click(object sender, EventArgs e)
        {
            IList<Dominio.Agenda> list_agenda;
            _agendaDao.Deletar(Convert.ToInt32(agenda_datagrid.Rows[agenda_datagrid.CurrentRow.Index].Cells[0].Value));
            list_agenda = _agendaDao.BuscarTodos();

            agenda_datagrid.DataSource = list_agenda;
            try
            {
                agenda_datagrid.Columns["Idservico"].Visible = false;
                agenda_datagrid.Columns["Idfuncionario"].Visible = false;
            }
            catch (Exception) { }
            agenda_datagrid.Update();
        }

        private void editar_horario_agenda_button_Click(object sender, EventArgs e)
        {
            Hide();
            Dominio.Agenda agenda_edit = _agendaDao.BuscarPorId(Convert.ToInt32(agenda_datagrid.Rows[agenda_datagrid.CurrentRow.Index].Cells[0].Value));

            Agenda_Editar_Tela AET = new Agenda_Editar_Tela(agenda_edit);
            AET.Show();
        }

        private void ver_extrato_Click(object sender, EventArgs e)
        {
            Extrato_Dias_Caixa EDC = new Extrato_Dias_Caixa();
            EDC.Show();
        }
    }
}
