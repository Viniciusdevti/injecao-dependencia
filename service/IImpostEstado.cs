using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInjecao.service
{
    public interface IImpostEstado
    {
        double CalcularImposto(ETiposDeImpostos tipoImposto, double valor);
    }
}
