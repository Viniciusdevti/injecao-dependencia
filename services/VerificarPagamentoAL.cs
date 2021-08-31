using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInjecao
{
    public class VerificarPagamentoAL : VerificarPagamento
    {
        
        public bool realizaRequest(bool verificaPagamento)
        {
            verificaPagamento = false;
            return verificaPagamento;
        }
    }
}
