// Programa para aeroporto

// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

static bool EfetuarLogin(string senha)
{
        if (senha == "29042006")
        {
            return true;
        }
        else
        {
            return false;
        }
}
string[] Nome = new string[2];
string[] Origem = new string[2];
string[] Destino = new string[2];
string[] Data = new string[2];

Console.WriteLine($@"
    -------------------------------------
    |    Bem vindo a tela de login      |
    |      da agencia AviaçãoBr!        |
    | Para iniciar é necessario colocar |
    |   seu nome de usuario e senha.    |
    -------------------------------------
");
    Console.WriteLine($"Por favor insira seu nome de usuario:");
    string usuario = Console.ReadLine()!;
    bool senhaValida;
    do
    {
    Console.WriteLine($"Por favor insira sua senha:");
    string senha = Console.ReadLine()!;
    senhaValida = EfetuarLogin(senha);

    } while (senhaValida != true);
//EfetuarLogin(); 




//cadastro
static void Cadastro(string[] Nome, string[] Origem, string[] Destino, string[] Data, int posicao)
{

    for (var i = 0; i < Nome.Length; i++)
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
//Cadastro(Nome, Origem, Destino, Data, 0);

static void Listar(string[] Nome, string[] Origem, string[] Destino, string[] Data, int posicao)
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($@"
        {Nome[i]}
        {Origem[i]}
        {Destino[i]}
        {Data[i]}
        ");

    }
}
//Listar(Nome, Origem, Destino, Data, 0);
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// menu

int qtdCadastro;


char opcao;//null
info:
do
{
    Console.Clear();//limpa o console
    Console.WriteLine($@"
    ---------------------------------
    |       BEM VINDO AO MENU       |
    | Escolha uma das opções abaixo |
    |     1- Cadastrar passagem     |
    |     2- Listar Passagens       |
    |     0- Sair                   |
    ---------------------------------
");
     opcao = char.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case '1':
            Console.WriteLine($@"
    ----------------------------------------
    | Bem vindo ao cadastro de passageiros |
    | Quantas pessoas você quer cadastrar? |
    | (Digite com números)                 |
    ----------------------------------------
    ");
            qtdCadastro = int.Parse(Console.ReadLine()!);

            Cadastro(Nome, Origem, Destino, Data, 0);
            Console.WriteLine($"Deseja adicionar mais algum passageiro? Digite s para sim e n para não.");
            char respostaC = char.Parse(Console.ReadLine()!);
            if (respostaC == 's')
            {
                qtdCadastro++;
                Cadastro(Nome, Origem, Destino, Data, 0);
            }
            else
            {
                goto info;
            }
            break;

        case '2':
            Listar(Nome, Origem, Destino, Data, 0);
            Console.WriteLine($"Deseja voltar? s para sim e n para não.");
            char resposta2 = char.Parse(Console.ReadLine()!);
            if(resposta2 == 's')
            {
                goto info;
            }
            else{
                Console.Clear();
            }
            break;

        case '0':
            goto info;


        default:
            Console.WriteLine($"opção invalida");
            break;
    }
} while (opcao != '0');
