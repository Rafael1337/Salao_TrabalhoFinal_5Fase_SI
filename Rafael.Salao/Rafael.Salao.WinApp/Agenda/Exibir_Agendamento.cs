using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Agenda;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Servicos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rafael.Salao.WinApp.Agenda
{
    public partial class Exibir_Agendamento : Form
    {

        public AgendaDao _agendaDao = new AgendaDao();


        public ServicosDao _servicosDao = new ServicosDao();
        public List<Servicos> _lista_servicos = new List<Servicos>();

        public FuncionarioDao _funcionarioDao = new FuncionarioDao();
        public List<Funcionario> _lista_funcionario = new List<Funcionario>();

        public Dominio.Agenda agenda = new Dominio.Agenda();

        public Exibir_Agendamento(Dominio.Agenda agenda_exibir)
        {
            agenda = agenda_exibir;
            InitializeComponent();
            PopulateFields();
            PopulateComboboxFuncionario(agenda_exibir);
            PopulateComboboxServico(agenda_exibir);
        }

        private void PopulateFields()
        {
            nome_cliente_txtbox.Text = agenda.Nome_cliente.ToString();
            horario_agenda.Text = agenda.Horario.ToString();
            data_agenda.Text = agenda.Data.ToString();
            telefone_cliente_textbox.Text = agenda.Telefone.ToString();
        }

        public void PopulateComboboxFuncionario(Dominio.Agenda agenda_exibir)
        {
            _lista_funcionario = _funcionarioDao.ObterFuncionarioParaCombobox(DabaseConnection.connection_created);
            foreach (var funcionario in _lista_funcionario)
            {
                agenda_funcionario_combobox.Items.Add(funcionario.Nome);
                if (funcionario.Nome == _agendaDao.Get_NameCombobox(agenda_exibir))
                {
                    agenda_funcionario_combobox.SelectedItem = _agendaDao.Get_NameCombobox(agenda_exibir);
                }
            }
        }

        public void PopulateComboboxServico(Dominio.Agenda agenda_exibir)
        {
            _lista_servicos = _servicosDao.ObterServicosParaCombobox();
            foreach (var servico in _lista_servicos)
            {
                agenda_servico_combobox.Items.Add(servico.Tipo);
                if(servico.Tipo == _agendaDao.GetTipoComboboxValue(agenda_exibir))
                {
                    agenda_servico_combobox.SelectedItem = _agendaDao.GetTipoComboboxValue(agenda_exibir);
                }
            }
        }

        private void voltar_tela_inicial_Click(object sender, EventArgs e)
        {
            Close();
            Tela_Inicial TI = new Tela_Inicial();
            TI.Show();
        }
    }
}
