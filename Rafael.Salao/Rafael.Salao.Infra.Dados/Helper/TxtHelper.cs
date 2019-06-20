using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael.Salao.Infra.Dados.Helper
{
    public class TxtHelper
    {
        public static string ReplacerFieldsInTXT(string Field, string NewField, string arquivo)
        {
            string newtext;
            if (arquivo.Contains(Field))
            {
                return newtext = arquivo.Replace(Field, NewField);
            }
            else
            {
                throw new Exception("Tag não existente no arquivo.");
            }
        }
    }
}
