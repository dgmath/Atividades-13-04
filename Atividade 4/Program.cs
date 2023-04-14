//4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
//menor valor lido.
float[] numero = new float[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira seu {i + 1}º valor ");
    numero[i] = float.Parse(Console.ReadLine()!);
}

    Console.WriteLine($"O maior numero é {numero.Max()} e o menor é {numero.Min()}");

