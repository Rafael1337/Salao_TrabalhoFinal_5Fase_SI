using System;

namespace Rafael.Salao.Dominio
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string Nome_cliente { get; set; }
        public string Telefone { get; set; }
        public int Idfuncionario { get; set; }
        public int IdServico { get; set; }
        public string Data { get; set; }

        public void Validacao()
        {
            //Nome_Cliente
            if (string.IsNullOrEmpty(Nome_cliente) || string.IsNullOrWhiteSpace(Nome_cliente))
            {
                throw new Exception("O Nome do cliente é um campo obrigatório");
            }

            //Horario
            else if (string.IsNullOrWhiteSpace(Horario) || string.IsNullOrEmpty(Horario))
            {
                throw new Exception("O Horário é um campo obrigatório para o Agendamento");
            }

            //Data
            else if (string.IsNullOrEmpty(Data) || string.IsNullOrWhiteSpace(Data))
            {
                throw new Exception("A Data é um campo obrigatório para o Agendamento");
            }


            //Data
            else if (string.IsNullOrEmpty(Telefone) || string.IsNullOrWhiteSpace(Telefone))
            {
                throw new Exception("O Telefone é um campo obrigatório para o Agendamento");
            }


            //Servicos 
            else if (IdServico == 0)
            {
                throw new Exception("Serviço é um campo obrigatório para o Agendamento de horários");
            }

            //Funcionario
            else if (Idfuncionario == 0)
            {
                throw new Exception("Funcionário é um campo obrigatório para o Agendamento de horáríos");
            }
        }
    }
}
