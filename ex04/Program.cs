// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

Console.WriteLine("Qual o seu nome ?");
string nome = Console.ReadLine();

Console.WriteLine("Qual o seu sobrenome ?");
string sobrenome = Console.ReadLine();

Console.WriteLine("Qual o seu último nome ?");
string lastname = Console.ReadLine();

Console.WriteLine($"Boas vindas {nome} {sobrenome} {lastname}");
