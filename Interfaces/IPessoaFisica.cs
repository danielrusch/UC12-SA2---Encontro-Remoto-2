using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime dataNasc);
    }
}