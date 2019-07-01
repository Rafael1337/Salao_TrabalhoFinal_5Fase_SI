using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Servicos;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Rafael.Salao.Infra.Dados.Agenda;

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

        public AgendaDao _agendaDao = new AgendaDao();
        public Agenda_Adicionar_Tela()
        {
            InitializeComponent();
            PopulateComboboxFuncionario();
            PopulateComboboxServico();
        }

        public void PopulateComboboxFuncionario()
        {
            _lista_funcionario = _funcionarioDao.ObterFuncionarioParaCombobox(DabaseConnection.connection_created);
            foreach (var funcionario in _lista_funcionario)
            {
                agenda_funcionario_combobox.Items.Add(funcionario.Nome);
            }
        }

        public void PopulateComboboxServico()
        {
            _lista_servicos = _servicosDao.ObterServicosParaCombobox();
            foreach(var servico in _lista_servicos)
            {
                agenda_servico_combobox.Items.Add(servico.Tipo);
            }
        }

        private void adicionar_agenda_button_Click(object sender, System.EventArgs e)
        {
            Dominio.Agenda ag = new Dominio.Agenda();
            Funcionario funcionario = new Funcionario();


            ag.Data = data_agenda.Text;
            ag.Horario = horario_agenda.Text;
            ag.Nome_cliente = nome_cliente_txtbox.Text;
            ag.Telefone = Convert.ToString(telefone_cliente_textbox.Text);
            ag.Idfuncionario = _agendaDao.GetFuncionarioData(agenda_funcionario_combobox.SelectedItem.ToString());
            ag.IdServico = _agendaDao.GetServicoData(agenda_servico_combobox.SelectedItem.ToString());

            try
            {
                ag.Validacao();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            _agendaDao.Adicionar(ag);

            Close();

            Tela_Inicial TI = new Tela_Inicial();
            TI.Show();
        }

        private void VerifyComboboxes(Dominio.Agenda ag)
        {
            try
            {
                ag.Idfuncionario = _agendaDao.GetFuncionarioData(agenda_funcionario_combobox.SelectedItem.ToString());
            }
            catch (Exception) { MessageBox.Show("Selecione algum valor para funcionario"); return; }
            try { ag.IdServico = _agendaDao.GetServicoData(agenda_servico_combobox.SelectedItem.ToString()); } catch (Exception) { MessageBox.Show("Selecione algum valor para servico"); return; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void horario_agenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nome_cliente_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agenda_servico_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agenda_funcionario_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void telefone_cliente_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void data_agenda_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
