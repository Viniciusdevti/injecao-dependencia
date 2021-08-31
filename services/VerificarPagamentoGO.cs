using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInjecao
{
    class VerificarPagamentoGO : VerificarPagamento
    {
        protected  bool realizaRequest(bool verificaPagamento)
        {
            verificaPagamento = true;
            return verificaPagamento;
        }

    }
}
