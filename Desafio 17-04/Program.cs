// 
static bool Login(string senha)
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
string[] Nomes = new string[2];
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
    senhaValida = Login(senha);

} while (senhaValida != true);

//menu de opcoes

Console.WriteLine($"Menu de opções");
Console.WriteLine($@" 
    Selecione uma das opções
    [1] - Cadastrar
    [2] - Cadastrar
    [0] - Cadastrar
    ");

string opcao = Console.ReadLine()!;
switch (opcao)
{
    case "1":
        string resposta;
        do
        {
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Informe o nome:");
                Nomes[i] = Console.ReadLine()!;
                Console.WriteLine($"Infrome a origem do passageiro:");
                Origem[i] = Console.ReadLine()!;
                Console.WriteLine($"Informe o destino do passageiro");
                Destino[i] = Console.ReadLine()!;
                Console.WriteLine($"Insira a data da viagem: (com o modelo dd/mm/aa)");
                Data[i] = Console.ReadLine()!;

            }
            Console.WriteLine($"Quer cadastrar mais passagens? (s para sim e n para não)");
            resposta = Console.ReadLine()!.ToLower();
        } while (resposta == "s");
        break;
    case "2":
        for (var i = 0; i < 2; i++)
        {
            Console.WriteLine(@$"
                *******************
                Passagens - Bilhete

                Nome: {Nomes[i]}
                Origem: {Origem[i]}
                Destino: {Destino[i]}
                Data: {Data[i]}
                ");
        }
        break;
    case "0":
        Console.WriteLine($"Fim do programa");
        break;
    default:
        Console.WriteLine($"Opção inválida!");
        break;
}
while (opcao != "0") ;




