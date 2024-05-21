// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int x = Menu();
swi

function int Menu (){
    Console.WriteLine("Ingrese que operacion desea realizar:\n1)Calcular Valor Absoluto\n2)El cuadrado\n3)Raiz Cuadrada\n4)Seno\n5)Coseno\n6)Parte entera de un numero");
    Console.WriteLine("Ingrese su opcion: ");
    string x = Console.ReadLine();
    int numero;
    int.TryParse(x, out numero);
    return numero;
}