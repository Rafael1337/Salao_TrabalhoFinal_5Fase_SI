using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Dominio
{
    public class Agenda
    {
        public int Id {get; set;}
        public string Horario { get; set; }
        public string Nome_cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Servicos Servicos { get; set; }
        public string Data { get; set; }

        public void ValidateAgenda()
        {
            if (string.IsNullOrEmpty(Horario) || string.IsNullOrWhiteSpace(Horario))
                throw new Exception("Horario é um campo obrigatório");

            if (string.IsNullOrEmpty(Nome_cliente) || string.IsNullOrWhiteSpace(Nome_cliente))
                throw new Exception("Nome do cliente é obrigatorio");

            if (string.IsNullOrEmpty(Data) || string.IsNullOrWhiteSpace(Data))
                throw new Exception("Data é um campo obrigatorio");

            if (Servicos.Cabelo == null || Servicos.Unha == null || Servicos.Depilacao == null)
                throw new Exception("Um tipo de servico deve ser informado");

            if (Funcionario.Id == 0)
                throw new Exception("Um funcionario deve ser informado");
        }
    }
}
