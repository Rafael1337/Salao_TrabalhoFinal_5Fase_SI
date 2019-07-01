using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Agenda;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            PopulateComboboxFuncionario();
            PopulateComboboxServico();
        }

        private void PopulateFields()
        {
            nome_cliente_txtbox.Text = agenda.Nome_cliente.ToString();
            horario_agenda.Text = agenda.Horario.ToString();
            data_agenda.Text = agenda.Data.ToString();
            telefone_cliente_textbox.Text = agenda.Telefone.ToString();
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
            _lista_servicos = _servicosDao.ObterServicosParaCombobox();
            foreach (var servico in _lista_servicos)
            {
                agenda_servico_combobox.Items.Add(servico.Tipo);
            }
            agenda_servico_combobox.SelectedIndex = 0;
        }

        private void voltar_tela_inicial_Click(object sender, EventArgs e)
        {
            Close();
            Tela_Inicial TI = new Tela_Inicial();
            TI.Show();
        }
    }
}
