using Rafael.Salao.Infra.Dados.Caixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafael.Salao.WinApp.Caixa
{
    public partial class Extrato_Dias_Caixa : Form
    {

        public CaixaDao _caixaDao = new CaixaDao();
        public Extrato_Dias_Caixa()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            IList<Dominio.Caixa> list_caixa;
            list_caixa = _caixaDao.BuscarTodos();

            show_extrato.DataSource = list_caixa;
            show_extrato.Update();
        }
    }
}
