using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes

{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public override void PagarImposto (float rendimento){
                     
        }
        public bool ValidarCNPJ (string cnpj){
            if (cnpj.Length >= 14 && (cnpj.Substring (cnpj.Length-4)) == "0001"){ //nº cnpj deve ter 14 digitos sendo os últimos 4 igual a 0001
                
                return true;

            } else{

                return false;
            }
            
        }
    }
}