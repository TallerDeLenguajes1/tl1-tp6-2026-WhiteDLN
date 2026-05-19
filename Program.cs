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



