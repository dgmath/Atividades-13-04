//6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
//lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
//pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
//entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[3];

bool nomeEncontrado = false;

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Insira o {i + 1}º nome: ");
        nomes[i] = Console.ReadLine()!;
    }
        Console.WriteLine($"Insira um nome para saber se ele esta na lista:");
        string nomeBuscado = Console.ReadLine()!;

        //Console.WriteLine($"{nomes.Contains(resposta)}");
        foreach (string nome in nomes)
        {
         if( nome == nomeBuscado)
         {
            nomeEncontrado = true;
             break;
         }
        //  else{
        //      Console.WriteLine($"NÃO ACHEI.");
        //      break;
        //  }
        }
Console.WriteLine(nomeEncontrado == true ? "ACHEI" : "NÃO ACHEI");


    // string resultado = resposta == true ? "ACHEI" : "NÃO ACHEI";


    //static string Resultado(nomes.Contains(resposta) == true? "Achei": "Não Achei") 
        
        

    
