using System.Security.Cryptography;


void ExibirMensagemDeBoasVindas()
{
    string mensagemDeBoasVindas = "Bem vindo ao JogoRpg!";
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para escolha do jogador1");
    Console.WriteLine("Digite 2 paraescolher o jogador2");
    Console.WriteLine("Digite 3 para voltar");



}
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu(); //chama a função no console


Console.ReadLine();
