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

        public override double PagarImposto (float rendimento){ //Colocamos o override para sobre escrever o método PagarImposto, pois ele já existe na classe-mãe
        //Para rendimentos até R$5.000,0 - Desconto 6%.
        //Para rendimentos entre R$5.001,0 até R$10.000,0 - Desconto 8%.
        //Para rendimentos acima de R$10.000,0 - Desconto 10%.

   if (rendimento <= 5000){
    return rendimento * .06;

   }else if (rendimento > 5001 && rendimento <= 10000){
    return rendimento * .08;

   }else{
    return rendimento * .1;

   }
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