// 

Console.WriteLine($"Informe o ano em que você nasceu:");
int anoNascimento = int.Parse(Console.ReadLine()!);

int idade = (DateTime.Now.Year - anoNascimento);
if(idade < 16)
{
    Console.WriteLine($"Você não pode votar!");
}
else
{
    Console.WriteLine($"Você pode votar!");
}