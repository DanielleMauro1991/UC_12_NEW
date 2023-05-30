using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes

{

public class PessoaFisica : Pessoa //Utilizar : para que as instâncias tenham acesso à todos os atributos da classe Pessoa
{
    public string? cpf { get; set; }

    public string? rg { get; set; }

    public DateTime DataNascimento { get; set; }

    public override double PagarImposto (float rendimento){ //Colocamos o override para sobre escrever o método PagarImposto, pois ele já existe na classe-mãe
   //Para rendimentos até R$1.500,0 - Desconto 0%.
   //Para rendimentos entre R$1.501,0 até R$5.000,0 - Desconto 3%.
   //Para rendimentos acima de R$5.000,0 - Desconto 5%.

   if (rendimento <= 1500){
    return rendimento * 0;

   }else if (rendimento > 1501 && rendimento <= 5000){
    return rendimento * .03;

   }else{
    return rendimento * .05;
   }
   }

    public bool ValidarDataNascimento (DateTime dataNasc){
        DateTime dataAtual = DateTime.Today;

        double anos = (dataAtual-dataNasc).TotalDays / 365; //Fórmula para obter a idade de uma pessoa

        if (anos >= 18){
            return true;
        } else {
            return false;
        }

    }
    
 }
}


