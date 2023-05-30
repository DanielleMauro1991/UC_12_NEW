using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes
{
    public abstract class Pessoa //Classe Abstrata= Não pode instanciar
    {
        public string? Nome {get; set;} //? Para deixar o objeto nullable
       public Endereco? endereco { get; set; } //Composição Endereço (uma classe dentro de outra classe)
        public abstract void PagarImposto (float rendimento); //Pessoa é a classe-mãe; PagarImposto é o método
    }
}