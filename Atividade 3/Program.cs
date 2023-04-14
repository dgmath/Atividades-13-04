// // 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <=; 5 o desconto será de 2%
// - Se quantidade >; 5 e quantidade <= 10 o desconto será de 3%
// - Se quantidade >; 10 o desconto será de 5%
// Dica: utilize if / else if / else

// float valor;
// int quant;
float resultado;
//descricao
Console.WriteLine($"Insira qual o nome do produto você esta comprando:");
string nome = Console.ReadLine()!;
//quantidade
Console.WriteLine($"Insira a qantidade de produto adiquirido: ");
int quant = int.Parse(Console.ReadLine()!);
//preco unitario
Console.WriteLine($"Insira o valor do produto:");
float valor = float.Parse(Console.ReadLine()!);
//calcular e mostrar total


if(quant <= 5)
{
    resultado = (valor * quant - valor * 2/ 100);
}
else if(quant > 5 && quant <= 10)
{
    resultado = (valor * quant - valor * 3/ 100);
}
else
{
    resultado = (valor * quant - valor * 5/ 100);
}

float resultado2 = valor * quant;

Console.WriteLine($"O valor a ser pago pelo produto sem desconto {nome} é de {resultado2.ToString("C", new System.Globalization.CultureInfo("pt-BR"))} e o valor com desconto é de {resultado.ToString("C", new System.Globalization.CultureInfo("pt-BR"))} ");
