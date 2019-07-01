using Rafael.Salao.Dominio;
using Rafael.Salao.Infra.Dados;
using Rafael.Salao.Infra.Dados.Agenda;
using Rafael.Salao.Infra.Dados.Funcionario;
using Rafael.Salao.Infra.Dados.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            string Nome = "";
            SqlCommand sqlcommand = new SqlCommand("SELECT NOME FROM TBFUNCIONARIO INNER JOIN TBAGENDA ON TBFUNCIONARIO.ID = " + agenda_exibir.Idfuncionario, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            using (SqlDataReader read = sqlcommand.ExecuteReader())
            {
                while (read.Read())
                {
                    Nome = (read["NOME"].ToString());
                }
            }
            DabaseConnection.connection_created.Close();

            _lista_funcionario = _funcionarioDao.ObterFuncionarioParaCombobox(DabaseConnection.connection_created);
            foreach (var funcionario in _lista_funcionario)
            {
                agenda_funcionario_combobox.Items.Add(funcionario.Nome);
                if (funcionario.Nome == Nome)
                {
                    agenda_funcionario_combobox.SelectedItem = Nome;
                }
            }
        }

        public void PopulateComboboxServico(Dominio.Agenda agenda_exibir)
        {
            string tipo = "";
            SqlCommand sqlcommand = new SqlCommand("SELECT TIPO FROM TBSERVICO INNER JOIN TBAGENDA ON TBSERVICO.ID = " + agenda_exibir.IdServico, DabaseConnection.connection_created);
            DabaseConnection.connection_created.Open();
            using (SqlDataReader read = sqlcommand.ExecuteReader())
            {
                while (read.Read())
                {
                    tipo = (read["TIPO"].ToString());
                }
            }
            DabaseConnection.connection_created.Close();


            _lista_servicos = _servicosDao.ObterServicosParaCombobox();
            foreach (var servico in _lista_servicos)
            {
                agenda_servico_combobox.Items.Add(servico.Tipo);
                if(servico.Tipo == tipo)
                {
                    agenda_servico_combobox.SelectedItem = tipo;
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
