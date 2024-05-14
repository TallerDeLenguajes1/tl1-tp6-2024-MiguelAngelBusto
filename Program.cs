// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

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
*/
int literal = Menu();
while (literal > 0)
{
    Console.WriteLine("Ingrese un numero");
    string a = Console.ReadLine();
    int x, y;
    int.TryParse(a, out x);
    Console.WriteLine("Ingrese el otro numero");
    string b = Console.ReadLine();
    int.TryParse(b, out y);
    Calculo(literal, x, y);
    Console.WriteLine("Desea realizar otro calculo (0 para no): ");
    string c = Console.ReadLine();
    int.TryParse(c, out literal);
    if (literal != 0)
    {
        literal = Menu();
    }
}



static int Menu()
{
    int literal = 0;
    Console.WriteLine("------CALCULADORA------");
    Console.WriteLine("1)SUMAR\n2)RESTAR\n3)MULTIPLICAR\n4)DIVIDIR\n\n\nIngrese una opcion: ");
    string x = Console.ReadLine();
    int.TryParse(x, out literal);
    return literal;
}

static void Calculo(int literal, int x, int y)
{
    int j;
    switch (literal)
    {
        case 1:
            j = x + y;
            Console.WriteLine("La suma de " + x + "+" + y + " es " + j);
            break;

        case 2:
            j = x - y;
            Console.WriteLine("La suma de " + x + "-" + y + " es " + j);
            break;

        case 3:
            j = x * y;
            Console.WriteLine("La suma de " + x + "*" + y + " es " + j);
            break;

        default:
            if (y != 0)
            {
                float h = x / y;
                Console.WriteLine("La suma de " + x + "/" + y + " es " + h);
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0");
            }
            break;
    }
}