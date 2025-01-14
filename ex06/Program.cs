// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int num2 = int.Parse(Console.ReadLine());

int soma = num1 + num2;
int sub = num1 - num2;
int mult = num1 * num2;
int div = num1 / num2;


Console.WriteLine($"A soma é: {soma}");
Console.WriteLine($"A subtração é: {sub}");
Console.WriteLine($"A multiplicação é: {mult}");
Console.WriteLine($"A divisão é: {div}");


if (num1 != 0)
{
    Console.WriteLine("/ : " + num1 / num2);
}
else
{
    Console.WriteLine("A divisão por 0 é indeterminada");
}



Console.WriteLine("======================================");
Console.WriteLine("Os números são iguais? " + (num1 == num2));
Console.WriteLine("Número 1 é maior que Número 2? " + (num1 > num2));
Console.WriteLine("Número 2 é maior que Número1?" + (num2 > num1));
Console.WriteLine("Número 1 é maior igual Numero 2? " + (num1 >= num2));
Console.WriteLine("Número 2 é maior igual Número 1? " + (num2 >= num1));