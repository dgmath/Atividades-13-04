// Programa para aeroporto

// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


Console.WriteLine($@"
    -------------------------------------
    |    Bem vindo a tela de login      |
    |      da agencia AviaçãoBr!        |
    | Para iniciar é necessario colocar |
    |   seu nome de usuario e senha.    |
    -------------------------------------
");



static void EfetuarLogin()
{
    Console.WriteLine($"Por favor insira seu nome de usuario:");
    string usuario = Console.ReadLine()!;

    bool senha = true;
    do
    {
        Console.WriteLine($"Por favor insira sua senha:");
        int resposta = int.Parse(Console.ReadLine()!);
        if (resposta == 29042006)
        {
            senha = true;
        }
        else
        {
            senha = false;
            Console.WriteLine($"Senha incorreta. Por fvor insira novamente.");
        }

    } while (senha == false);
}
EfetuarLogin();

//cadastro
    string[] Nome = new string[] {};
    string[] Origem = new string[] {};    
    string[] Destino = new string[] {};
    string[] Data = new string[] {};
static void Cadastro()
{

    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($"Para cadastrar sua passagem é preciso inserir o nome do passageiro:");
        Nome[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a origem do passageiro:");
        Origem[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira o destino do passageiro:");
        Destino[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a data da viagem: (com o modelo dd/mm/aa)");
        Data[i] = Console.ReadLine()!;
    }

}
Cadastro();

static string Listar()
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($@"
        {Nomes[i]}
        {Origem[i]}
        {Destino[i]}
        {Data[i]}
        ");
        
    }
}

switch (value)
{
    case value1:
        break;
    default:
        break;
}

