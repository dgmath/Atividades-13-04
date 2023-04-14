// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
//Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (int t = 1; t <= 10; t++)
{
    for (int contador = 1; contador <= 10; contador++)
    {
        int formula = t * contador;
        Console.WriteLine(t + " X " + contador + " = " + formula);
    }
}