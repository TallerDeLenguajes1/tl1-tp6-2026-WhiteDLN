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


Console.WriteLine("Ingrese una cadena de texto.");
string Caneda1 = Console.ReadLine();

Console.WriteLine($"Longitud de la cadena: {Caneda1.Length}.");


Console.WriteLine("Ingrese una segunda cadena de texto.");
string Cadena2 = Console.ReadLine();
string Concatenada = Caneda1 + " " + Cadena2;
Console.WriteLine(Concatenada);

Console.WriteLine("CALCULADORA CON RESULTADO EN TEXTO");

int numCalc1 = PedirNumero("Ingrese el primer numero: ");
int numCalc2 = PedirNumero("Ingrese el segundo numero: ");

Console.WriteLine("Seleccione la operacion:");
Console.WriteLine("[1] Sumar");
Console.WriteLine("[2] Restar");
Console.WriteLine("[3] Multiplicar");
Console.WriteLine("[4] Dividir");
int opcionCalc = int.Parse(Console.ReadLine());

int resultadoCalc = 0;
string nombreOp = "";

switch (opcionCalc)
{
    case 1:
        resultadoCalc = numCalc1 + numCalc2;
        nombreOp = "suma";
        break;
    case 2:
        resultadoCalc = numCalc1 - numCalc2;
        nombreOp = "resta";
        break;
    case 3:
        resultadoCalc = numCalc1 * numCalc2;
        nombreOp = "multiplicacion";
        break;
    case 4:
        if (numCalc2 != 0)
        {
            resultadoCalc = numCalc1 / numCalc2;
            nombreOp = "division";
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            nombreOp = "division (error)";
        }
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

if (opcionCalc >= 1 && opcionCalc <= 4 && !(opcionCalc == 4 && numCalc2 == 0))
{
    Console.WriteLine($"La {nombreOp} de {numCalc1.ToString()} y de {numCalc2.ToString()} es igual a: {resultadoCalc.ToString()}");
}

Console.WriteLine("Elementos de la cadena:");
foreach(char c in Caneda1){
    Console.WriteLine($"{c}");
}


Console.Write("Ingrese la palabra a buscar: ");
string palabraBuscar = Console.ReadLine();

if (Cadena1.Contains(palabraBuscar))
{
    int posicion = Cadena1.IndexOf(palabraBuscar);
    Console.WriteLine($"La palabra '{palabraBuscar}' se encuentra en la posición {posicion}");
}
else
{
    Console.WriteLine($"La palabra '{palabraBuscar}' NO se encuentra en la cadena");
}


console.WriteLine($"Mayusculas:  {Caneda1.ToUpper()}");
Console.WriteLine($"Minusculas: {Cadena1.ToLower()}");

Console.Write("Ingrese una cadena separada por comas (ej: perro,gato,pez): ");
string cadenaSeparada = Console.ReadLine();
string[] elementos = cadenaSeparada.Split(',');

Console.WriteLine("Elementos separados:");
foreach (string elemento in elementos)
{
    Console.WriteLine($"  - {elemento.Trim()}");
}

Console.Write("Ingrese una ecuación simple (ej: 582+2): ");
string ecuacion = Console.ReadLine();

ResolverEcuacion(ecuacion);

static void ResolverEcuacion(string ecuacion)
{
    char operador = ' ';
    string[] partes = null;

    if (ecuacion.Contains('+')) {
        operador = '+'; 
        partes = ecuacion.Split('+'); 
        }
    else if (ecuacion.Contains('-')) {
         operador = '-'; 
         partes = ecuacion.Split('-'); 
         }
    else if (ecuacion.Contains('*')) {
         operador = '*'; 
         partes = ecuacion.Split('*'); 
         }
    else if (ecuacion.Contains('/')) {
         operador = '/'; 
         partes = ecuacion.Split('/'); 
         }
    else
    {
        Console.WriteLine("Ecuación inválida. Use +, -, * o /");
        return;
    }

    if (partes.Length != 2)
    {
        Console.WriteLine("Ecuación inválida. Debe tener dos números");
        return;
    }

    if (double.TryParse(partes[0], out double num1) && double.TryParse(partes[1], out double num2))
    {
        double resultado = 0;
        string nombreOp = "";

        switch (operador)
        {
            case '+': resultado = num1 + num2; nombreOp = "suma"; break;
            case '-': resultado = num1 - num2; nombreOp = "resta"; break;
            case '*': resultado = num1 * num2; nombreOp = "multiplicación"; break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    nombreOp = "división";
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    return;
                }
                break;
        }

        Console.WriteLine($"La {nombreOp} de {num1} y {num2} es igual a: {resultado}");
    }
    else
    {
        Console.WriteLine("Error: Asegúrese de ingresar números validos");
    }
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