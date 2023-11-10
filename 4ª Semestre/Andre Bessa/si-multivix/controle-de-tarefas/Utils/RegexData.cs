using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace controle_de_tarefas.Utils
{
    internal static class RegexData
    {
        public static bool ValidaFormatoDataSimples(String data)
        {
            Regex dataSimples = new Regex(@"^\d{2}/\d{2}/\d{4}$");

            return dataSimples.IsMatch(data.ToString());
        }
    }
}
