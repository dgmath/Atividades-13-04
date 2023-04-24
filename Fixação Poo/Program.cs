using Fixação_Poo;
bool Validar = true;

Calculadora c1 = new Calculadora();

Console.WriteLine($"Insira seu primeiro numero: ");
c1.n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o segundo numero: ");
c1.n2 = float.Parse(Console.ReadLine()!);



do
{
Console.WriteLine($@"
------------------------------------------------
|Selecione o tipo de operação que você deseja: |  
|            + - Somar                         |
|            - - Subtrair                      |
|            * - Multiplicar                   |
|            / - Dividir                       |
------------------------------------------------

");

string resposta = Console.ReadLine()!;
switch (resposta)
{
    case "+":
        Validar = false;
        // float resultado = c1.Somar();
        Console.WriteLine($"O resultado da soma é {c1.Somar()}");
        break;

    case "-":
    Validar = false;
        Console.WriteLine($"O resultado da subtração é {c1.Subtrair()}");
        break;

    case "/":
    Validar = false;
        Console.WriteLine($"O resultado da multiplicação é {c1.Dividir()}");
        break;

    case "*":
    Validar = false;
        Console.WriteLine($"O resultado da divisão é {c1.Multiplicar()}");
        break;
    default:
    Validar = true;
        Console.WriteLine($"Insira um valor valido.");
        break;
}
}while(Validar == true);

