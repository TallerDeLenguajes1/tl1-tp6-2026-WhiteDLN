int bandera = 0;
int numero = 0;
int resultadoI = 0;

do {
    int Eleccion;
    Console.WriteLine("Seleccione la opcion que desea realizar:");
    Console.WriteLine("[0]Salir");
    Console.WriteLine("[1]Sumar");
    Console.WriteLine("[2]Restar");
    Console.WriteLine("[3]Multiplicar");
    Console.WriteLine("[4]Dividir");
    if(int.TryParse(Console.ReadLine(), out Eleccion) && Eleccion >= 0 && Eleccion <= 4) {

        if(Eleccion == 0){
            Console.WriteLine("Saliendo del programa...");
            bandera = 1;
        }

        else{
        int num1 = PedirNumero("Ingrese el primer valor:");
        int num2; //RECUERDA INICIALIZAR
        int resultado;

        switch(Eleccion){
            case 1:
            num2 = PedirNumero("Ingrese el segundo valor:");
            resultado = num1 + num2;
            Console.WriteLine("Resultado: " + resultado);
            break;

            case 2:
            num2 = PedirNumero("Ingrese el segundo valor:");
            resultado = num1 - num2;
            Console.WriteLine("Resultado: " + resultado);
            break;

            case 3:
            num2 = PedirNumero("Ingrese el segundo valor:");
            resultado = num1 * num2;
            Console.WriteLine("Resultado: " + resultado);
            break;

            case 4:
            num2 = PedirDividendo("Ingrese un numero diferente a 0.");
            resultado = num1 / num2;
            Console.WriteLine("Resultado: " + resultado);
            break;

        }
    }

    }

}while (bandera == 0);


Console.WriteLine("Ingrese un numero");


if(int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("El numero ingresado es: " + numero);
    while (numero > 0)
{
    resultadoI = resultadoI * 10 + numero % 10;
    
    numero = numero / 10;
}

Console.WriteLine("El numero invertido es: " + resultadoI);


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

static int PedirDividendo(string Mensaje){
    int Numero;
    bool Valido;

    do {
        Console.WriteLine(Mensaje);
        Valido = int.TryParse(Console.ReadLine(), out Numero);

        if (!Valido){
            Console.WriteLine("Debe ingresar un numero valido.");
        }

        else if(Numero == 0){
            Console.WriteLine("El divisor no puede ser 0.");
            Valido = false;
        }
    }while(!Valido);

    return Numero;
}