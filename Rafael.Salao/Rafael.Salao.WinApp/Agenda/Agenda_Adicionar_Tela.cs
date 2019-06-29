using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Servicos;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Rafael.Salao.WinApp.Agenda
{
    public partial class Agenda_Adicionar_Tela : Form
    {
        public Funcionario funcionario = new Funcionario();
        public FuncionarioDao _funcionarioDao = new FuncionarioDao();
        public List<Funcionario> _lista_funcionario = new List<Funcionario>();

        public Servicos servicos = new Servicos();
        public ServicosDao _servicosDao = new ServicosDao();
        public List<Servicos> _lista_servicos = new List<Servicos>();


        public Agenda_Adicionar_Tela()
        {
            InitializeComponent();
            PopulateComboboxFuncionario();
        }

        public void PopulateComboboxFuncionario()
        {

            _lista_funcionario = _funcionarioDao.ObterFuncionarioParaCombobox(DabaseConnection.connection_created);
            foreach (var funcionario in _lista_funcionario)
            {
                agenda_funcionario_combobox.Items.Add(funcionario.Nome);
            }
            agenda_funcionario_combobox.SelectedIndex = 0;
        }

        public void PopulateComboboxServico()
        {
            //_lista_servicos = _servicosDao.ObterServicoParaCombobox(DabaseConnection.connection_created);
            //foreach (var servicos in _lista_servicos)
            //{
            //    agenda_funcionario_combobox.Items.Add(servicos.Nome);
            //}
            //agenda_funcionario_combobox.SelectedIndex = 0;
        }
    }
}
