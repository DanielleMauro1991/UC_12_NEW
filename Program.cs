using System.Diagnostics;
using Sistema_UC12.Classes;

class Program
{
    static void Main(string[] args) //Atalho svm + Enter
{

 
 void BarraCarregamento(string textocarregamento){ //Comando para simular carregamento
  
  Console.WriteLine(textocarregamento);
  Thread.Sleep(500); //Cronômetro para barra de carregamento

 for(var contador = 0; contador < 10; contador++){
  Console.Write("▌ ");
  Thread.Sleep(500);
   }
 }

 Console.Clear(); //Comando necessário para o menu em cores
 Console.ForegroundColor = ConsoleColor.Magenta;
 //Console.BackgroundColor = ConsoleColor.DarkBlue;

 Console.WriteLine(@$"
 Seja Bem Vindo ao Cadastro de Clientes.
 ");

BarraCarregamento("Iniciando");

Console.Clear();

string opcao;

do{ //Faça isso, enquanto a condição for verdadeira

Console.WriteLine(@$"
 Escolha uma das opções abaixo:

 1 - Pessoa Física;
 2 - Pessoa Jurídica;

 0 - Sair;
 ");

 opcao = Console.ReadLine(); //Programa irá receber comando do usuário

switch(opcao){

  case "1": 

  string? opcaoPF; //Submenu de Pessoa Física

do{

  Console.Clear ();
  Console.WriteLine(@$"
 Escolha uma das opções abaixo:

 1 - Cadastrar Pessoa Física;
 2 - Mostrar Pessoas Físicas;

 0 - Voltar ao menu anterior;
 ");

opcaoPF = Console.ReadLine();

switch (opcaoPF){

  case "1": //Cadastrar pessoa física

  PessoaFisica novapf = new PessoaFisica ();
  Endereco endereco = new Endereco ();

  Console.WriteLine("Digite o nome da Pessoa Física que deseja cadastrar");
  novapf.Nome = Console.ReadLine();



   Console.WriteLine("Digite a data de nascimento   EX: DD/MM/AAAA");
   novapf.DataNascimento = DateTime.Parse(Console.ReadLine()); //Padrão americano= Ano; mês; dia

  bool idadeValidade = novapf.ValidarDataNascimento (novapf.DataNascimento);

   if (idadeValidade == true){
   Console.WriteLine ($"{novapf.Nome} é maior de idade");
   }else{
   Console.WriteLine ($"{novapf.Nome} é menor de idade");
   }



   Console.WriteLine("Digite o CPF");
   novapf.cpf = Console.ReadLine();



   novapf.endereco = endereco;

   Console.WriteLine("Digite o logradouro");
   endereco.logradouro = Console.ReadLine();

   Console.WriteLine("Digite o número");
   endereco.numero = int.Parse(Console.ReadLine());

   Console.WriteLine("Digite o complemento");
   endereco.complemento = Console.ReadLine();

   Console.WriteLine("Trata-se de local comercial?  S/N");
   string endCom = Console.ReadLine().ToUpper();

   if (endCom == "S"){
    endereco.enderecoComercial = true;
   } else{
    endereco.enderecoComercial = false;
   }
     
  break;

  case "2": 
  break;

  case "0": 
  break;

  default: 
  Console.Clear();
  Console.Write("Opção Inválida, digite novamente");
  Thread.Sleep(2000);
  break;
}

}while (opcaoPF != "0");

break;

     
  // Console.WriteLine($"O endereço do {novapf.Nome} é {novapf.endereco.logradouro}, nº {novapf.endereco.numero}.");
  
  
  

 
  case "2":
  Endereco endereconovo = new Endereco ();

  endereconovo.logradouro = "Rua Niterói";
  endereconovo.numero = 180;
  endereconovo.complemento = "Escola SENAI";
  endereconovo.enderecoComercial = true;

 PessoaJuridica novapj = new PessoaJuridica ();


novapj.endereco = endereconovo;
novapj.Nome = "SENAI";
novapj.RazaoSocial = "Empresa";
novapj.cnpj = "02518838990001";

if (novapj.ValidarCNPJ(novapj.cnpj)){

Console.WriteLine ("CNPJ Válido");
  
}else{

Console.WriteLine ("CNPJ Inválido");
}
  
Console.WriteLine($"O endereço do {novapj.cnpj} é {novapj.endereco.logradouro}, nº {novapj.endereco.numero}.");

  break;
  
  case "0":
  Console.WriteLine("Obrigado! Volte sempre!");
 
  BarraCarregamento ("Finalizando");

  break;
  
  default:
  Console.WriteLine("Opção Inválida");
  break;
}
} while (opcao != "0");

 Console.ResetColor();// Comando necessário para que o console não saia na cor do menu

}

}



//Console.WriteLine (novapf.endereco.logradouro);
//Console.WriteLine (novapf.endereco.numero);
//Console.WriteLine (novapf.endereco.complemento);
//Console.WriteLine (novapf.endereco.enderecoComercial);

//Console.WriteLine (novapf.Nome);
//Console.WriteLine (novapf.DataNascimento);

//Interpolação

//Console.WriteLine($"O endereço do {novapf.Nome} é {novapf.endereco.logradouro}, nº {novapf.endereco.numero}.");

//Concatenação

//Console.WriteLine ("O endereço do "+ novapf.Nome + " é " + novapf.endereco.logradouro + ", nº " + novapf.endereco.numero +".");









