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