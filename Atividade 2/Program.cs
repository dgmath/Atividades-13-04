// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

//Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
//da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
//sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

// float A = 0;
// float G = 0;
bool repetir = true;
char nome ;
do{
   Console.WriteLine($"Insira qual tipo de combustivel você quer: a para álcool ou g para gasolina");
    nome = char.Parse(Console.ReadLine()!.ToUpper()); 

if(nome == 'a')
{
    repetir = true;
    Console.WriteLine($"Você escolheu Alcool");
}
else if(nome == 'g')
{
    repetir = true;
    Console.WriteLine($"Você escolheu Gasolina");
}
else{
    repetir = false;
    Console.WriteLine($"Insira uma letra valida!");
}
}while(repetir == false);

Console.WriteLine($"Insira a quantidade de litros:");
float Litros = float.Parse(Console.ReadLine()!);


static float Desconto(float Litros, char nome)
{
    
    if(Litros <= 20 && nome == 'a')
    {
        return Litros * 4.90F - 4.90F * 3 / 100;
    }
    else if(Litros > 20 && nome == 'a')
    {
        return Litros * 4.90F - 4.90F * 5 / 100;
    }
    else if(Litros <= 20 && nome == 'g')
    {
        return Litros * 5.30F - 5.30F * 4 / 100;
    }
    else 
    {
        return Litros * 5.30F - 5.30F * 6 / 100;
    }
}

float resultado = Desconto(Litros,nome);
Console.WriteLine($"O valor a ser pago é: {resultado.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
