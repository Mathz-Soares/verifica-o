//não pode número iguais, digitar o maior deles, 2 números.
using System.Security.Cryptography;

Console.WriteLine("digite dois valores que não sejam iguais, irei mostrar o maior deles");
Console.WriteLine("digite o primeiro número");
int i1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("digite o segundo número");
int i2 = Convert.ToInt16(Console.ReadLine());

if (i1 > i2)
{
    Console.WriteLine("O primeiro número é maior ({0}) é maior", i1);
}
else if (i2 > i1)
{
    Console.WriteLine("O segundo número é maior ({0}) é maior", i2);
}
else 
{
    Console.WriteLine("os números são iguais, tente de novo");
}
 