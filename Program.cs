﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese un numero: ");
string x = Console.ReadLine();
int numero;
int.TryParse(x, out numero);
if (numero > 10)
{
    int aux = 0;
    int reto;
    do
    {
        reto = numero % 10;
        numero = numero / 10;
        aux = aux + reto;
        if (numero > 0)
        {
            aux = aux * 10;
        }
    } while (numero > 0);
    Console.WriteLine("El numero invertido es: " + aux);
}
else
{
    Console.WriteLine("El numero invertido es: " + numero);
}