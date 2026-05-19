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



int numeroC1 = 0;
int numeroC2 = 0;
int operacion = 0;

if (int.TryParse(Console.ReadLine(), out numeroC1) && int.TryParse(Console.ReadLine(), out numeroC2))
{

    bool OperacionValida = false;
    OperacionValida = int.TryParse(Console.ReadLine(), out operacion);

    
    do
    {
        if (!OperacionValida)
    {
        Console.WriteLine("El valor ingresado no es un numero valido.");
        return;
    }

    else {
        Console.WriteLine("Ingrese la operacion a realizar: 1 para suma, 2 para resta, 3 para multiplicacion y 4 para division");
        Console.ReadLine();
        switch(operacion)
        {
            case 1:
                Console.WriteLine("La suma es: " + (numeroC1 + numeroC2));
                break;
            case 2:
                Console.WriteLine("La resta es: " + (numeroC1 - numeroC2));
                break;
            case 3:
                Console.WriteLine("La multiplicacion es: " + (numeroC1 * numeroC2));
                break;
            case 4:
                Console.WriteLine("La division es: " + (numeroC1 / numeroC2));
                break;
        }
    }

    }
    while(operacion < 1 || operacion > 4);
    
}



else
{
    Console.WriteLine("El valor ingresado no es un numero valido.");
}