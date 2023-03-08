using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f;
            }

            else if (rendimento > 3000  &&  rendimento <= 6000)
            {
                return rendimento * 0.05f;
            }

               else if (rendimento >6000  &&  rendimento <= 10000)
            {
                return rendimento * 0.07f;
            }

            else
            {
                 return rendimento * 0.09f;
            }
            }

        public bool ValidarCnpj(string Cnpj)

        {
          bool retornoCnpjValido = Regex.IsMatch (Cnpj, @"^(\d{14}) | (\d{2}.\d{3}.\d{3}\d{4}-\d{2}}) $");

          if (retornoCnpjValido) 
          {
            string substringCnpj14 = Cnpj.Substring(8,4); // depois de quantos caracteres defino quantos eu quero analisar

            if (substringCnpj14 == "0001" )

            {
                return true;
            }
          }

          string substringCnpj18 = Cnpj.Substring(11,4);

           if (substringCnpj18 == "0001" )

            {
                return true;
            }
            
            return false;
        }
    }
}