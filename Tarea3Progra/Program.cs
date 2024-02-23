//1  
int num1, num2, num3;
  int mayor;
        Console.WriteLine("introduzca el primer numero:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("introduzca el segundo numero:");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("introduzca el tercer numero:");
        num3 = int.Parse(Console.ReadLine());
       
mayor = num1;
        if (num2 > mayor)
        {
            mayor = num2;
        }
        if (num3 > mayor)
        {
            mayor = num3;
        }
 Console.WriteLine("el mayor de los tres numeros es: " + mayor);

//2
int edad;

Console.WriteLine("ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

if  (edad >= 18)
{
    Console.WriteLine("bienvenido");
}
else
{
    Console.WriteLine("No admitido, por ser menor :( ");
}


        //3
        double precioOriginal, precioFinal;
        const double DESCUENTO = 0.1; 


        Console.WriteLine("introduzca el precio original del producto:");
        precioOriginal = double.Parse(Console.ReadLine());

        if (precioOriginal > 100)
        {
            precioFinal = precioOriginal * (1 - DESCUENTO);
        }
        else
        {
            precioFinal = precioOriginal;
        }
        Console.WriteLine("el precio final del producto es: Q" + precioFinal);


//4
        const string USUARIO_CORRECTO = "mauri";
        const string CONTRASENA_CORRECTA = "1234";

        // Solicitud de credenciales
        Console.WriteLine("introduzca su nombre de usuario:");
        string usuario = Console.ReadLine();

        Console.WriteLine("introduzca su contraseña:");
        string contrasena = Console.ReadLine();

        // Validación de credenciales
        if (usuario == USUARIO_CORRECTO && contrasena == CONTRASENA_CORRECTA)
        {
            Console.WriteLine("acceso concedido.");
        }
        else
        {
            Console.WriteLine("acceso denegado. credenciales incorrectas.");
        }


//5
Console.WriteLine("introduzca un numero: ");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.WriteLine("el numero {0} es par.", numero);
}
else
{
    Console.WriteLine("el numero {0} es impar.", numero);
}



//6
Console.WriteLine("introduzca el monto del prestamo: ");
double montoPrestamo = double.Parse(Console.ReadLine());

Console.WriteLine("introduzca su edad: ");
int edadUsuario = int.Parse(Console.ReadLine());

bool prestamoAprobado = false;
if (montoPrestamo < 5000 || edadUsuario > 60)
{
    prestamoAprobado = true;
}
if (prestamoAprobado)
{
    Console.WriteLine("su prestamo a sido aprobado");
}
else
{
    Console.WriteLine("lo sentimos, su prestamo ha sido rechazado.");
}


//7
Console.WriteLine("introduzca el tipo de figura geometrica, pueden ser; triangulo, cuadrado y circulo: ");
string tipoFigura = Console.ReadLine().ToLower();


double area = 0;
switch (tipoFigura)
{
    case "triangulo":
        Console.WriteLine("introduzca la base del triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("introduzca la altura del triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        area = (baseTriangulo * alturaTriangulo) / 2;
        break;
    case "cuadrado":
        Console.WriteLine("introduzca el lado del cuadrado: ");
        double ladoCuadrado = double.Parse(Console.ReadLine());
        area = ladoCuadrado * ladoCuadrado;
        break;
    case "circulo":
        Console.WriteLine("introduzca el radio del circulo: ");
        double radioCirculo = double.Parse(Console.ReadLine());
        area = Math.PI * radioCirculo * radioCirculo;
        break;
    default:
        Console.WriteLine("tipo de figura geometrica no valida.");
        break;
}


if (area > 0)
{
    Console.WriteLine("el area de la figura es {0}.", area);
}

//ejercicios usando switch
//1

Console.WriteLine("Introduzca un número del 1 al 5 en letra; uno, dos, tres, cuatro, cinco: ");
string numeroLetra = Console.ReadLine().ToLower();

switch (numeroLetra)
{
    case "uno":
        numero = 1;
        break;
    case "dos":
        numero = 2;
        break;
    case "tres":
        numero = 3;
        break;
    case "cuatro":
        numero = 4;
        break;
    case "cinco":
        numero = 5;
        break;
    default:
        Console.WriteLine("numero en letra no valido.");
        break;
}


if (numero > 0)
{
    Console.WriteLine("el numero en digito es {0}.", numero);
}

//2
Console.WriteLine("introduzca un numero del 1 al 7: ");
int NUMERO = int.Parse(Console.ReadLine());

string diaSemana = "";
switch (numero)
{
    case 1:
        diaSemana = "Lunes";
        break;
    case 2:
        diaSemana = "Martes";
        break;
    case 3:
        diaSemana = "Miércoles";
        break;
    case 4:
        diaSemana = "Jueves";
        break;
    case 5:
        diaSemana = "Viernes";
        break;
    case 6:
        diaSemana = "Sabado";
        break;
    case 7:
        diaSemana = "Domingo";
        break;
    default:
        Console.WriteLine("numero no valido.");
        break;
}

if (diaSemana != "")
{
    Console.WriteLine("el dia de la semana correspondiente al numero {0} es {1}.", numero, diaSemana);
}

//3
Console.WriteLine("introduzca el tipo de servicio; lavado de auto, cambio de aceite, revisión mecanica: ");
string tipoServicio = Console.ReadLine().ToLower();
double importe = 0;
switch (tipoServicio)
{
    case "lavado de auto":
        importe = 60;
        break;
    case "cambio de aceite":
        importe = 150;
        break;
    case "revision mecanica":
        importe = 200;
        break;
    default:
        Console.WriteLine("tipo de servicio no valido.");
        break;
}

if (importe > 0)
{
    Console.WriteLine("el importe a pagar por el servicio {0} es de; Q{1}.", tipoServicio, importe);
}


//4
Console.WriteLine("introduzca el idioma de su preferencia; español, ingles, frances: ");
string idioma = Console.ReadLine().ToLower();


string mensajeBienvenida = "";
switch (idioma)
{
    case "español":
        mensajeBienvenida = "¡Hola! Bienvenido a mi programa.";
        break;
    case "ingles":
        mensajeBienvenida = "Hello! Welcome to my program.";
        break;
    case "frances":
        mensajeBienvenida = "Bonjour! Bienvenue dans mon programme.";
        break;
    default:
        Console.WriteLine("Idioma no valido.");
        break;
}


if (mensajeBienvenida != "")
{
    Console.WriteLine(mensajeBienvenida);
}

//5
Console.WriteLine("Introduzca la calificación del examen: ");
string calificacionTexto = Console.ReadLine();

int calificacion;
if (int.TryParse(calificacionTexto, out calificacion))
{
    string mensajeDesempeno = "";
    switch (calificacion)
    {
        case 90:
        case 91:
        case 92:
        case 93:
        case 94:
        case 95:
        case 96:
        case 97:
        case 98:
        case 99:
        case 100:
            mensajeDesempeno = "Sobresaliente";
            break;
        case 80:
        case 81:
        case 82:
        case 83:
        case 84:
        case 85:
        case 86:
        case 87:
        case 88:
        case 89:
            mensajeDesempeno = "Notable";
            break;
        case 70:
        case 71:
        case 72:
        case 73:
        case 74:
        case 75:
        case 76:
        case 77:
        case 78:
        case 79:
            mensajeDesempeno = "Bueno";
            break;
        case 60:
        case 61:
        case 62:
        case 63:
        case 64:
        case 65:
        case 66:
        case 67:
        case 68:
        case 69:
            mensajeDesempeno = "Raspado";
            break;
        case 50:
        case 51:
        case 52:
        case 53:
        case 54:
        case 55:
        case 56:
        case 57:
        case 58:
        case 59:
            mensajeDesempeno = "Insuficiente";
            break;
        default:
            mensajeDesempeno = "Calificacion invalida.";
            break;
    }

    // Mostrar el mensaje de desempeño
    if (mensajeDesempeno != "")
    {
        Console.WriteLine("su desempeño en el examen es {0}.", mensajeDesempeno);
    }
}
else
{
    Console.WriteLine("La calificacion introducida no es un numero valido.");
}




