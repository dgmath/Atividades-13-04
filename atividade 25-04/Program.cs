using atividade_25_04;
//Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

Celular c1 = new Celular();
inicio:
Console.WriteLine($"Celular esta ligado? s para sim e n para não");
string resposta = Console.ReadLine()!.ToUpper();
switch (resposta)
{
    case "S":
        c1.ligado = true;
        break;
    case "N":
        c1.ligado = false;
        break;
    default:
        Console.WriteLine($"Digite algo valido.");
        goto inicio;
}

if (c1.ligado == true)
{
volta:
    Console.WriteLine($@"
---------------------------------------
|  Bem vindo. Selecione oque deseja:  |
|  [1] - Fazer ligação                |
|  [2] - Enviar mensagem              |
|  [0] - Desligar                     |
---------------------------------------
");
    string selecao = Console.ReadLine()!;
    switch (selecao)
    {
        case "1":
            c1.FazerLigacao();
            break;
        case "2":
            c1.EnviarMensagem();
            break;
        case "0":
            c1.Desligar();
            break;

        default:
            Console.WriteLine($"Por favor insira algo valido.");
            goto volta;
    }
}
else
{
    Console.WriteLine($"Por favor ligue o aparelho para prosseguir com as funcionalidades. Digite 1 para ligar ou n para cancelar");
    string resultado = Console.ReadLine()!.ToUpper();
    switch (resultado)
    {
        case "1":
            c1.Ligar();
            c1.ligado = true;
            c1.Inicio();
            break;
    }
}




