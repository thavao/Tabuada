//2 - faça um programa que leia um numero inteiro positivo e imprima a sua tabuada

int numero;

Console.WriteLine("Digite um número inteiro positivo: ");
numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("Tabuada do " + numero);
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}
else
    Console.WriteLine("O valor precisa ser positivo...");

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();