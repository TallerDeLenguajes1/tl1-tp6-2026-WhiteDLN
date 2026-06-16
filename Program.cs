// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
int numero = 0;
int resultado = 0;

Console.WriteLine("Ingrese un numero");


if(int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("El numero ingresado es: " + numero);
    while (numero > 0)
{
    resultado = resultado * 10 + numero % 10;
    
    numero = numero / 10;
}

Console.WriteLine("El numero invertido es: " + resultado);


}
else
{
    Console.WriteLine("El valor ingresado no es un numero valido.");
}   



double ValorAMostrar = PedirNumeroDouble("Elija el valor que desee saber El valor absoluto de un número El cuadrado, La raíz cuadrada  El seno y El Coseno");
double Absoluto, Cuadrado, Raiz;

Absoluto = Math.Abs(ValorAMostrar);
Console.WriteLine("El valor Absoluto es: " + Absoluto);

Cuadrado = Math.Pow(ValorAMostrar, 2);
Console.WriteLine("El cuadrado es: " + Cuadrado);

if(ValorAMostrar >= 0){
    Raiz = Math.Sqrt(ValorAMostrar);
    Console.WriteLine("La raiz es: " + Raiz);
}
else {
    Console.WriteLine("No se puedde sacar la raiz cuadrada de un negativo.");
}

double radianes = ValorAMostrar * Math.PI / 180.0;
Console.WriteLine($"Seno: {Math.Sin(radianes)}");
Console.WriteLine($"Coseno: {Math.Cos(radianes)}");

float numeroFloat = PedirNumeroFloat("Ingrese un decimal.");
double parteEntera = Math.Truncate(numeroFloat);
Console.WriteLine("La parte entera de: " + numeroFloat + "es: " + parteEntera);






static int PedirNumero(string Mensaje){
    int Numero;
    bool Valido;

    do {
        Console.WriteLine(Mensaje);
        Valido = int.TryParse(Console.ReadLine(), out Numero);

        if (!Valido){
            Console.WriteLine("Debe ingresar un numero valido.");
        }
    }while(!Valido);

    return Numero;
}

static double PedirNumeroDouble(string Mensaje)
{
    double Numero;
    bool Valido;

    do
    {
        Console.WriteLine(Mensaje);
        Valido = double.TryParse(Console.ReadLine(), out Numero);

        if (!Valido)
        {
            Console.WriteLine("Debe ingresar un numero valido.");
        }
    } while (!Valido);

    return Numero;
}

static float PedirNumeroFloat(string Mensaje)
{
    float Numero;
    bool Valido;

    do
    {
        Console.WriteLine(Mensaje);
        Valido = float.TryParse(Console.ReadLine(), out Numero);

        if (!Valido)
        {
            Console.WriteLine("Debe ingresar un numero valido.");
        }
    } while (!Valido);

    return Numero;
}