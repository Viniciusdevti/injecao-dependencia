using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInjecao.service
{
    public class ImpostoService
    {
        private readonly double _valorTotal;
        public   ImpostoService(IImpostEstado impostoEstado, ETiposDeImpostos tipoImposto, double valor)
        {
            _valorTotal = impostoEstado.CalcularImposto(tipoImposto, valor);
        }
        public double ValorTotal()
        {
            return _valorTotal; 
        }
    }
}
