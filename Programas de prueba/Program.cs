class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Conversión de tipos");
            Console.WriteLine("2. Operaciones con tipos de datos");
            Console.WriteLine("3. Uso de char y string");
            Console.WriteLine("4. Uso de tipo de datos numéricos");
            Console.WriteLine("0. Salir");

            Console.Write("Ingrese su opción: ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MenuConversionTipos();
                        break;
                    case 2:
                        MenuOperacionesTiposDatos();
                        break;
                    case 3:
                        MenuCharYString();
                        break;
                    case 4:
                        MenuTiposNumericos();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
            }

            Console.WriteLine();
        }
    }

    static void MenuConversionTipos()
    {
        while (true)
        {
            Console.WriteLine(" \nMenu Conversión de Tipos");
            Console.WriteLine("1. convertir un numero entero a decimal: ");
            Console.WriteLine("2. convertir un numero decimal a flotante: ");
            Console.WriteLine("3. Convertir un numero flotante a entero");
            Console.WriteLine("4. convertir un caracter a entero");
            Console.WriteLine("5. convertir un entero a caracter");
            Console.WriteLine("0. Regresar al menu principal");

            Console.Write("seleccione lo que desea ver de acuerdo a los numeros del 1-5 ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número entero para convertir a decimal: ");
                        int Num1 = Convert.ToInt32(Console.ReadLine());
                        decimal numeroDecimal = Num1 / 1.0m;
                        Console.WriteLine($"Aqui esta su numero entero convertido a decimal: {numeroDecimal.ToString("0.0")}");
                        break;
                    case 2:
                        Console.Write("Ingresa un numero decimal para hacerlo flotante: ");
                        decimal NumDecimal = Convert.ToDecimal(Console.ReadLine());

                        float numeroFlotante = Convert.ToSingle(NumDecimal);

                        Console.WriteLine($"Numero decimal convertido a flotante: {numeroFlotante}");
                        break;
                    case 3:
                        Console.Write("Ingresa un numero flotante para convertir a un numero entero: ");
                        float numeroFlotante2 = Convert.ToSingle(Console.ReadLine());
                        int numeroEntero2 = Convert.ToInt32(numeroFlotante2);
                        Console.WriteLine($"Numero flotante convertido a entero: {numeroEntero2}");
                        break;
                    case 4:
                        Console.Write("Ingrese un caracter para convertir a entero: ");
                        char caracter = Console.ReadLine()[0];
                        int valorEntero = (int)caracter;
                        Console.WriteLine($"El caracter a sido convertido a entero: {valorEntero}");
                        break;
                    case 5:
                        do
                        {
                            Console.Write("Ingrese un entero para convertir a caracter: ");
                            int numeroEntero;
                            if (!int.TryParse(Console.ReadLine(), out numeroEntero))
                            {
                                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                                continue;
                            }

                            char caracte;

                            if (numeroEntero >= 32 && numeroEntero <= 126)
                            {
                                caracte = (char)numeroEntero;
                                Console.WriteLine($"Entero convertido a caracter: {caracte}");
                            }
                            else
                            {
                                Console.WriteLine("El número entero no corresponde a un carácter imprimible de ASCII. Por favor, ingrese un número del 32 al 126.");
                            }

                            Console.Write("¿Deseas ingresar otro número? (S/N): ");
                            char respuesta = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                            if (respuesta != 'S' && respuesta != 's')
                            {
                                break;
                            }

                        } while (true);
                        break;

                    case 0:
                        return;
                    default:
                        Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
            }

            Console.WriteLine();
        }
    }



    static void MenuOperacionesTiposDatos()
    {
        while (true)
        {
            Console.WriteLine(" \nMenu de Operaciones de tipo de Datos");
            Console.WriteLine("1. suma de dos numeros enteros: ");
            Console.WriteLine("2. resta de dos numeros decimales: ");
            Console.WriteLine("3. multiplicacion de dos numeros flotantes: ");
            Console.WriteLine("4. division de dos numeros enteros: ");
            Console.WriteLine("5. Modulo de dos numeros enteros: ");
            Console.WriteLine("0. Regresar al menu principal: ");

            Console.Write("Ingrese su opción: ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese su primer numero entero: ");
                        int suma1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese su segundo numero entero: ");
                        int suma2 = Convert.ToInt32(Console.ReadLine());

                        int suma = suma1 + suma2;

                        Console.WriteLine($" su respuesta es: {suma} ");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese su primer numero decimal:");
                        double resta1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero decimal:");
                        double resta2 = Convert.ToDouble(Console.ReadLine());

                        double resta = resta1 - resta2;

                        Console.WriteLine($"La respuesta de la resta es: {resta}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el primer numero flotante:");
                        float multi1 = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero flotante:");
                        float multi2 = Convert.ToSingle(Console.ReadLine());

                        float multiplicacion = multi1 * multi2;

                        Console.WriteLine($"la respuesta de la multiplicacion de numeros flotantes es {multiplicacion}");

                        break;
                    case 4:
                        Console.WriteLine("Ingrese su dividendo (número entero):");
                        int dividendo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el divisor (número entero distinto de cero):");
                        int divisor = Convert.ToInt32(Console.ReadLine());

                        if (divisor == 0)
                        {
                            Console.WriteLine(" Que haces? no puedes dividir entre 0 ");
                        }
                        else
                        {
                            int division = dividendo / divisor;
                            Console.WriteLine($"su division de numeros enteros es {division}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Ingrese el primer número entero:");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo número entero (distinto de cero):");
                        int num2 = Convert.ToInt32(Console.ReadLine());


                        if (num2 == 0)
                        {
                            Console.WriteLine("tu segundo digito no puede ser 0 ");
                        }
                        else
                        {

                            int modulo = num1 % num2;
                            Console.WriteLine($"El módulo de {num1} entre {num2} es: {modulo}");
                        }

                        break;

                    case 0:
                        return;
                    default:
                        Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
                        break;

                }

            }
            Console.WriteLine();
        }

    }
    static void MenuCharYString()
    {
        while (true)
        {
            Console.WriteLine(" \nMenu de uso de char y string");
            Console.WriteLine("1.Lee cadena de texto y imprime en mayuscula: ");
            Console.WriteLine("2.Lee cadena de texto y imprime en minuscula: ");
            Console.WriteLine("3.lee cadena de texto y lo imprime al revez ");
            Console.WriteLine("4.Lee una cadena de texto y busca una palabra: ");
            Console.WriteLine("5.lee cadena de texto y cuenta cuantas vocales contiene:");
            Console.WriteLine("0. regresarl al menu principal: ");

            Console.Write("Ingrese su opción: ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Escribe tu cadena de texto:");
                        string mayus = Console.ReadLine();

                        string mayusculas = mayus.ToUpper();

                        Console.WriteLine(" \nLa cadena en mayúsculas es: {0}", mayusculas);
                        break;
                    case 2:

                        Console.WriteLine("Escribe tu cadena de texto");
                        string minus = Console.ReadLine();

                        string minusculas = minus.ToLower();

                        Console.WriteLine("\nLa cadena en minúsculas es: {0}", minusculas);

                        break;
                    case 3:
                        Console.WriteLine("ingresa tu cadena de texto :");
                        string revez = Console.ReadLine();

                        string reversa = ReverseString(revez);

                        Console.WriteLine("\nla cadena al revez es: {0}", reversa);
                        break;

                        static string ReverseString(string input)
                        {
                            char[] charArray = input.ToCharArray();
                            Array.Reverse(charArray);
                            return new string(charArray);
                        }
                        break;

                    case 4:

                        Console.WriteLine("Ingresa tu cadena de texto");
                        string texto = Console.ReadLine();

                        Console.WriteLine("Que palabra deseas encontrar? ");
                        string palabra = Console.ReadLine();

                        bool encontrada = BuscarPalabra(texto, palabra);

                        if (encontrada)
                        {
                            Console.WriteLine("\nLa palabra '{0}' fue encontrada en el texto ", palabra);
                        }
                        else
                        {
                            Console.WriteLine("\nLa palabra '{0}' no a sido encontrada :(", palabra);
                        }
                        break;
                        static bool BuscarPalabra(string texto, string palabra)
                        {
                            string[] palabras = texto.Split(' ');


                            foreach (string p in palabras)
                            {
                                if (p.ToLower() == palabra.ToLower())
                                {
                                    return true;
                                }
                            }

                            return false;
                        }

                    case 5:
                        Console.WriteLine("Ingresa tu cadena de texto ");
                        string tex = Console.ReadLine();

                        int contadorVocales = ContarVocales(tex);

                        Console.WriteLine("\nEl número de vocales en el texto es: {0}", contadorVocales);
                        break;
                        static int ContarVocales(string texto)
                        {
                            int contador = 0;
                            foreach (char c in texto)
                            {

                                char caracter = char.ToLower(c);

                                if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                                {
                                    contador++;
                                }
                            }
                            return contador;
                        }

                    case 0:
                        return;
                    default:
                        Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
                        break;

                }
            }
            Console.WriteLine();
        }

    }

    static void MenuTiposNumericos()
    {
        while (true)
        {
            Console.WriteLine(" \nMenu de uso de tipo de datos numericos: ");
            Console.WriteLine("1. calcular el area de in triangulo: ");
            Console.WriteLine("2. calcular el volumen de una esfera: ");
            Console.WriteLine("3. calcular la distancia de dos puntos: ");
            Console.WriteLine("4. calcular la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius: ");
            Console.WriteLine("5. calcular la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit: ");
            Console.WriteLine("0. regresar al menu principal: ");

            Console.Write("Ingrese su opción: ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la longitud del primer lado de su triangulo: ");
                        double lado1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la longitud del segundo lado del triangulo: ");
                        double lado2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la longitud del tercer lado del triangulo: ");
                        double lado3 = double.Parse(Console.ReadLine());

                        double area = CalcularAreaTriangulo(lado1, lado2, lado3);

                        Console.WriteLine("\nEl área del triangulo es: {0}", area);
                        break;
                        static double CalcularAreaTriangulo(double lado1, double lado2, double lado3)
                        {
                            double semiperimetro = (lado1 + lado2 + lado3) / 2;

                            double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

                            return area;
                        }
                    case 2:
                        Console.WriteLine("Ingresa el radio de la esfera: ");
                        double radio = double.Parse(Console.ReadLine());

                        double volumen = CalcularVolumenEsfera(radio);

                        Console.WriteLine("\nEl volumen de la esfera es: {0}", volumen);
                        break;
                        static double CalcularVolumenEsfera(double radio)
                        {

                            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
                            return volumen;
                        }

                    case 3:
                        Console.WriteLine("Ingresa las coordenadas del primer punto: ");
                        Console.Write("Coordenada X: ");
                        double x1 = double.Parse(Console.ReadLine());
                        Console.Write("Coordenada Y: ");
                        double y1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa las coordenadas del segundo punto: ");
                        Console.Write("Coordenada X: ");
                        double x2 = double.Parse(Console.ReadLine());
                        Console.Write("Coordenada Y: ");
                        double y2 = double.Parse(Console.ReadLine());

                        double distancia = CalcularDistancia(x1, y1, x2, y2);

                        Console.WriteLine("\nLa distancia entre los dos puntos es: {0}", distancia);
                        break;
                        static double CalcularDistancia(double x1, double y1, double x2, double y2)
                        {

                            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                            return distancia;
                        }
                    case 4:
                        Console.WriteLine("Ingresa la temperatura en grados Celsius:");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = ConvertirACelsius(celsius);
                        Console.WriteLine("\n{0} grados Celsius equivalen a {1} grados Fahrenheit.", celsius, fahrenheit);
                        break;
                        static double ConvertirACelsius(double celsius)
                        {

                            double fahrenheit = (celsius * 9 / 5) + 32;
                            return fahrenheit;
                        }

                    //hola este es mi codigo 
                    case 5:
                        Console.WriteLine("Ingresa la temperatura en grados Fahrenheit:");
                        double fait = double.Parse(Console.ReadLine());
                        double cel = ConvertirAFahrenheit(fait);
                        Console.WriteLine("\n{0} grados Fahrenheit equivalen a {1} grados Celsius.", fait, cel);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("esta opcion no es valida, por favor seleccione otra.");
            }
            Console.WriteLine();
        }
    }

    static double ConvertirAFahrenheit(double fahrenheit)
    {

        double celsius = (fahrenheit - 32) * 5 / 8;
        return celsius;
    }
}
