using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInjecao.service
{
    public class VerificarImpostoPB : IImpostEstado
    {
        private const double II = 1.5;
        private const double IOF = 2.5;
        private const double IPI = 7.5;
        private const double IRPF = 8.8;

        public double CalcularImposto(ETiposDeImpostos tipoImposto, double valor)
        {
            return VerificarTipoImposto(tipoImposto) * valor;
        }

        public double VerificarTipoImposto(ETiposDeImpostos tipoImposto)
        {
            double valorTipoImposto;
            switch (tipoImposto)
            {
                case ETiposDeImpostos.II:
                    valorTipoImposto = II;
                    break;
                case ETiposDeImpostos.IOF:
                    valorTipoImposto = IOF;
                    break;
                case ETiposDeImpostos.IPI:
                    valorTipoImposto = IPI;
                    break;
                case ETiposDeImpostos.IRPF:
                    valorTipoImposto = IRPF;
                    break;
                default:
                    valorTipoImposto = 0;
                    break;
            }

            return valorTipoImposto;
        }
    }
}