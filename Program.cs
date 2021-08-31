using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteInjecao.service;

namespace TesteInjecao
{
    class Program
    {
        static void Main(string[] args)

        {
            ImpostoService impostoService = new ImpostoService(new VerificarImpostoPB(), ETiposDeImpostos.IOF, 1 );

            
           Console.Write("Valor total com imposto: "  + impostoService.ValorTotal() );
            Console.ReadLine();
        }
    }
}
