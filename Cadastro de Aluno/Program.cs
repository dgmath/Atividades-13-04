// 
// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using Cadastro_de_Aluno;

Aluno a1 = new Aluno();

Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@$"

--------------------------------------------------
|  Bem vindo ao programa da Escola José Chediak  |
|  insira seus dados para descobrir se você tem  |
|      direito a bolsa ou não.                   |
--------------------------------------------------
");
Console.ResetColor();

Console.WriteLine();
Console.WriteLine($"Insira seu nome: ");
a1.nome = Console.ReadLine()!;

Console.WriteLine($"Insira seu curso: ");
a1.curso = Console.ReadLine()!;

Console.WriteLine($"Insira sua idade: ");
a1.idade = Console.ReadLine()!;

Console.WriteLine($"Insira seu rg: ");
a1.rg = Console.ReadLine()!;

Console.WriteLine($"Insira se você é bolsista: s para sim e n para não");
string resposta = Console.ReadLine()!.ToLower();


a1.bolsista = (resposta == "s");

// switch (resposta)
// {
//     case "s":
//     a1.bolsista = true;
//         break;
//         case "n":
//         a1.bolsista = false;
//         break;
//     default: Console.WriteLine($"Insira um valor valido.");
//         goto bolsa;
// }

Console.WriteLine($"Insira sua media final: ");
a1.mediaF = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira sua mensalidade : ");
a1.ValorMensalidade = float.Parse(Console.ReadLine()!);

menu:
Console.WriteLine($@"
----------------------------------------
|        Bem vindo ao menu!            |
|  Escolha qual função você quer hoje: |
|         1 - Média                    |
|         2 - Mensalidade              |
|         0 - Sair                     |
----------------------------------------
");
string numero = Console.ReadLine()!;

switch (numero)
{
    case "1":
        a1.Media();
        goto menu;

    case "2":
        a1.Mensalidade();
        goto menu;

    case "0":
        Console.Clear();
        break;
    default:

        goto menu;
}




