using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_Remoto_2.Interfaces;

namespace Encontro_Remoto_2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
       public string? Cnpj {get; set;}

       public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string Cnpj)
        {
            throw new NotImplementedException();
        }
    }
}