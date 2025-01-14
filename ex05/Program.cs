// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int num2 = int.Parse(Console.ReadLine());

int soma = num1 + num2;

Console.Clear();

Console.WriteLine("==============");
Console.WriteLine($"A soma é: {soma}");
Console.WriteLine("==============");

