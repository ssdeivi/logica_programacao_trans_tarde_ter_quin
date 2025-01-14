// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual a sua primeira nota ? ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Qual a sua segunda nota ? ");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Qual a sua terceira nota ? ");
float n3 = float.Parse(Console.ReadLine());

float media = (n1 + n2 + n3) / 3;

if (media >= 7)
{
    Console.WriteLine($"Sua média foi {media}");
    Console.WriteLine("Você está aprovado!");
}
else if (media < 4)
{
    Console.WriteLine($"Sua média foi {media}");
    Console.WriteLine("Você está de recuperação!");
}


