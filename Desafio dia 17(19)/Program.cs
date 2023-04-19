//Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

//Os produtos terão os seguintes atributos:
//string Nome
//float Preco
//bool Promocao (se está em promoção ou não)

//O sistema deverá ter as seguintes funcionalidades:
//CadastrarProduto
//ListarProdutos
//MostrarMenu
//Crie função(ões) para otimizar o código.
//Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


string[] nome = new string[10];
float[] preço = new float[10];
bool[] promocao = new bool[10];

//Senha
static bool Login(string senha)
{
    if (senha == "1234")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Cadastrar
static void CadastrarProduto(string[] nome, float[] preço, bool[] promocao)
{
    for (var i = 0; i < nome.Length; i++)
    {
        Console.WriteLine($"Insira o nome do seu {i + 1}º produto: ");
        nome[i] = Console.ReadLine()!;
        Console.WriteLine($"Insira o valor do seu produto: ");
        preço[i] = float.Parse(Console.ReadLine()!);

    info:
        Console.WriteLine($"Seu produto está em promoção?: (digite s para sim e n para não)");
        string resposta = (Console.ReadLine()!);
        switch (resposta)
        {
            case "s":
                promocao[i] = true;

                break;
            case "n":
                promocao[i] = false;
                break;
            default:
                Console.WriteLine($"Opção invalida. Insira novamente");
                goto info;
        }
    }
}
//CadastrarProduto(nome, preço, promocao);

// Listar
static void Listar(string[] nome, float[] preço, bool[] promocao)
{
    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine(@$"
                 *******************
                 Lista - Compras

                 Nome: {nome[i]}
                 Preço: {preço[i].ToString("C", new System.Globalization.CultureInfo("pt-BR"))}
                 Está em promoção: {promocao[i]}

                 ");
    }
}

//Inicio
Console.WriteLine($@"
    -------------------------------------
    |    Bem vindo a tela de login      |
    |     do mercado dos Carecas!       |
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

//Menu
static void MostrarMenu(string[] nome, float[] preço, bool[] promocao)
{
    menu:

    string opçao;//null
    do
    {
        
        Console.Clear();//limpa o console
        Console.WriteLine($@"
    ---------------------------------
    |       BEM VINDO AO MENU       |
    | Escolha uma das opções abaixo |
    |     1- Cadastrar Produto      |
    |     2- Listar Produtos        |
    |     0- Sair                   |
    ---------------------------------
");

        opçao = Console.ReadLine()!;

        switch (opçao)
        {
            case "1":
                Console.WriteLine($@"
    ----------------------------------------
    |   Bem vindo ao cadastro de Produtos  |
    ----------------------------------------
    ");
        CadastrarProduto(nome, preço, promocao);
        break;

            case "2":
                Listar(nome, preço, promocao);
                Console.WriteLine($"Deseja voltar para o menu? s para sim e n para não.");
                string resposta2 = Console.ReadLine()!;
                if (resposta2 == "s")
                {
                    goto menu;
                }
                else
                {
                    Console.Clear();
                }
                break;
        }
    } while (opçao != "0");
}
MostrarMenu(nome, preço, promocao);






