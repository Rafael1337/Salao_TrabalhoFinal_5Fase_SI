using System;
using System.Windows.Forms;
using Rafael.Salao.Dominio;

namespace Rafael.Salao.WinApp.Funcionarios
{
    public partial class Funcionarios_Adicionar_Tela : Form
    {
        public Funcionarios_Adicionar_Tela()
        {
            InitializeComponent();
        }

        private void gravar_funcionar_button_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
        }
    }
}
