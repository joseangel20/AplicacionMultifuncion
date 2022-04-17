public class Conversor
{
    public static void inicio()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("||====================================||");
            Console.WriteLine("||          MENU DE CONVERSOR         ||");
            Console.WriteLine("||====================================||");
            Console.WriteLine("||      1.CONVERSOR DE UNIDADES       ||");
            Console.WriteLine("||      2.CONVERSOR DE MONEDAS        ||");
            Console.WriteLine("||      3.SALIR                       ||");
            Console.WriteLine("||====================================||");
            Console.WriteLine("");
            Console.WriteLine("Elige una opcion");
            var opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "1":
                    grado();
                    break;

                case "2":
                    moneda();
                    break;

                case "3":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    static void continuar()
    {
        Console.ReadKey();
        Console.WriteLine("Presiones enter para continuar...\n");
        Console.ReadKey();
    }

    //funcion de fahrenheit almacena la formula y todos sus datos
    static void fahrenheit()
    {
        string igual = "La convension que acaba de hacer se mostrara el mismo resultado\n";
        string resul = "El valor que ingresaste es: ";
        do
        {
            double f, c, k;
            Console.Clear();
            Console.Write("||====================================||\n");
            Console.Write("||       CONVERSOR DE FAHRENHEIT      ||\n");
            menugrado();
            Console.WriteLine("Elige a que grado quiere convertir el grado Fahrenheit");
            var opcion = (Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingresa el valor de grados Fahrenheit: ");
                    f = Convert.ToDouble(Console.ReadLine());
                    Console.Write(igual);
                    Console.WriteLine(resul + f);
                    continuar();
                    break;

                case "2":
                    Console.Write("Ingresa el valor de grados Fahrenheit: ");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("La conversion de " + f + " grado Fahrenheit a grado Celsius es: " + c);
                    continuar();
                    break;

                case "3":
                    Console.Write("Ingresa el valor de grados Fahrenheit: \n");
                    f = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    k = (f + 459.67) * 5 / 9;
                    Console.WriteLine("La conversion de " + f + " grado Fahrenheit a grado Kelvin es: " + k);
                    continuar();
                    break;

                case "4":
                    Console.Write("Ingresa el valor de grados Fahrenheit: \n");
                    f = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    Console.WriteLine(resul + f);
                    c = (f - 32) * 5 / 9;
                    k = (f + 459.67) * 5 / 9;
                    Console.WriteLine("La conversion de " + f + " grado Fahrenheit a grado Celsius es: " + c);
                    Console.WriteLine("La conversion de " + f + " grado Fahrenheit a grado Kelvin es: " + k);
                    continuar();
                    break;

                case "5":
                    grado();
                    break;

                case "6":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    //funcion de celsius almacenado todos su aatos
    static void celsius()
    {
        string igual = "La convension que acaba de hacer se mostrara el mismo resultado\n";
        string resul = "El valor que ingresaste es: ";
        do
        {
            double f, c, k;
            Console.Clear();
            Console.Write("||====================================||\n");
            Console.Write("||       CONVERSOR DE CELSIUS         ||\n");
            menugrado();
            Console.WriteLine("Elige a que grado quiere convertir el grado Celcius");
            var opcion = (Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingresa el valor de grados Celsius: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = c * 9 / 5 + 32;
                    Console.WriteLine("La conversion de " + c + " grado Celsius a grado Fahrenheit es: " + f);
                    continuar();
                    break;

                case "2":
                    Console.Write("Ingresa el valor de grados Celsius: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.Write(igual);
                    Console.WriteLine(resul + c);
                    continuar();
                    break;

                case "3":
                    Console.Write("Ingresa el valor de grados Celsius: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    k = c + 273.15;
                    Console.WriteLine("La conversion de " + c + " grado Celsius a grado Kelvin es: " + k);
                    continuar();
                    break;

                case "4":
                    Console.Write("Ingresa el valor de grados Celsius: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    Console.WriteLine(resul + c);
                    f = c * 9 / 5 + 32;
                    k = c + 273.15;
                    Console.WriteLine("La conversion de " + c + " grado Celsius a grado Fahrenheit es: " + f);
                    Console.WriteLine("La conversion de " + c + " grado Celsius a grado Kelvin es: " + k);
                    continuar();
                    break;

                case "5":
                    grado();
                    break;

                case "6":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    //funcion de kelvin almacena todos sus datos

    static void kelvin()
    {
        string igual = "La convension que acaba de hacer se mostrara el mismo resultado\n";
        string resul = "El valor que ingresaste es: ";
        do
        {
            double f, c, k;
            Console.Clear();
            Console.Write("||====================================||\n");
            Console.Write("||       CONVERSOR DE KELVIN          ||\n");
            menugrado();
            Console.WriteLine("Elige a que grado quiere convertir el grado Kelvin");
            var opcion = (Console.ReadLine());

            switch (opcion)
            {

                case "1":
                    Console.Write("Ingresa el valor de grados Kelvin: ");
                    k = Convert.ToDouble(Console.ReadLine());
                    f = 1.8 * (k - 273) + 32;
                    Console.WriteLine("La conversion de " + k + " grado Kelvin a grado Fahrenheit es: " + f);
                    continuar();
                    break;

                case "2":
                    Console.Write("Ingresa el valor de grados Kelvin: ");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    c = k - 273.15;
                    Console.WriteLine("La conversion de " + k + " grado Kelvin a grado Celsius es: " + c);
                    continuar();
                    break;

                case "3":
                    Console.Write("Ingresa el valor de grados Kelvin: ");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.Write(igual);
                    Console.WriteLine(resul + k);
                    continuar();
                    break;

                case "4":
                    Console.Write("Ingresa el valor de grados Celsius: \n");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    Console.WriteLine(resul + k);
                    f = 1.8 * (k - 273) + 32;
                    c = k - 273.15;
                    Console.WriteLine("La conversion de " + c + " grado Celsius a grado Fahrenheit es: " + f);
                    Console.WriteLine("La conversion de " + c + " grado Celsius a grado Kelvin es: " + c);
                    continuar();
                    break;

                case "5":
                    grado();
                    break;

                case "6":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    //funcion de menu
    static void menugrado()
    {

        string menupri = "||====================================||\n";
        menupri += "||         1.FAHRENHEIT               ||\n";
        menupri += "||         2.CELSIUS                  ||\n";
        menupri += "||         3.KELVIN                   ||\n";
        menupri += "||         4.VER TODO LOS RESULTADO   ||\n";
        menupri += "||         5.VOLVER                   ||\n";
        menupri += "||         6.SALIR                    ||\n";
        menupri += "||====================================||\n";

        Console.WriteLine(menupri);
    }


    //funcion de principal de grado
    static void grado()
    {
        do
        {
            string menupri = "||====================================||\n";
            menupri += "||       CONVERSOR DE TEMPERATURA     ||\n";
            menupri += "||====================================||\n";
            menupri += "||         1.FAHRENHEIT               ||\n";
            menupri += "||         2.CELSIUS                  ||\n";
            menupri += "||         3.KELVIN                   ||\n";
            menupri += "||         4.VOLVER                   ||\n";
            menupri += "||         5.SALIR                    ||\n";
            menupri += "||====================================||\n";


            Console.Clear();
            Console.WriteLine(menupri);
            Console.WriteLine("");
            Console.WriteLine("Elige el cualquier medida de temperatura");
            var opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "1":
                    fahrenheit();
                    break;

                case "2":
                    celsius();
                    break;

                case "3":
                    kelvin();
                    break;

                case "4":
                    inicio();
                    break;

                case "5":
                    continuar();
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    static void moneda()
    {
        do
        {

            string menupri = "||====================================||\n";
            menupri += "||         CONVERSOR DE MONEDA        ||\n";
            menupri += "||====================================||\n";
            menupri += "||         1.PESO DOMINICANO          ||\n";
            menupri += "||         2.DOLLAR                   ||\n";
            menupri += "||         3.EURO                     ||\n";
            menupri += "||         4.VOLVER                   ||\n";
            menupri += "||         5.SALIR                    ||\n";
            menupri += "||====================================||\n";

            Console.Clear();
            Console.WriteLine(menupri);
            Console.WriteLine("");
            Console.WriteLine("Elige el cualquier tipo de moneda");
            var opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "1":
                    pesodominicano();
                    break;

                case "2":
                    dollar();
                    break;

                case "3":
                    euro();
                    break;

                case "4":
                    inicio();
                    break;

                case "5":
                    continuar();
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    static void menumoneda()
    {
        string menupri = "||====================================||\n";
        menupri += "||         1.PESO DOMINICANO          ||\n";
        menupri += "||         2.DOLLAR                   ||\n";
        menupri += "||         3.EURO                     ||\n";
        menupri += "||         4.VER TODO LOS RESULTADO   ||\n";
        menupri += "||         5.VER PAISES               ||\n";
        menupri += "||         6.VOLVER                   ||\n";
        menupri += "||         7.SALIR                    ||\n";
        menupri += "||====================================||\n";

        Console.WriteLine(menupri);
    }
    static void pesodominicano()
    {
        string igual = "La convension que acaba de hacer se mostrara el mismo resultado\n";
        string resul = "El valor que ingresaste es: ";
        do
        {
            double pd, d, e;
            Console.Clear();
            Console.Write("||====================================||\n");
            Console.Write("||    CONVERSOR DE PESO DOMINICANO    ||\n");
            menumoneda();
            Console.WriteLine("Elige a que moneda quiere convertir el peso dominicano");
            var opcion = (Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la cantida de Peso Dominicano: ");
                    pd = Convert.ToDouble(Console.ReadLine());
                    Console.Write(igual);
                    Console.WriteLine(resul + pd);
                    continuar();
                    break;

                case "2":
                    Console.Write("Ingrese la cantida de Peso Dominicano: ");
                    pd = Convert.ToDouble(Console.ReadLine());
                    d = (pd * 0.0181777);
                    Console.WriteLine("La conversion de " + pd + " Peso Dominicano a Dollar es: " + d);
                    continuar();
                    break;

                case "3":
                    Console.Write("Ingrese la cantida de Peso Dominicano: ");
                    pd = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    e = (pd * 0.016699);
                    Console.WriteLine("La conversion de " + pd + " Peso Dominicano a Euro es: " + e);
                    continuar();
                    break;

                case "4":
                    Console.Write("Ingrese la cantida de Peso Dominicano: \n");
                    pd = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    Console.WriteLine(resul + pd);
                    d = (pd * 0.0181777);
                    e = (pd * 0.016699);
                    Console.WriteLine("La conversion de " + pd + " Peso Dominicano a Dollar es: " + d);
                    Console.WriteLine("La conversion de " + pd + " Peso Dominicano a Euro es: " + e);
                    continuar();
                    break;

                case "5":
                    paisdp();
                    break;

                case "6":
                    moneda();
                    break;

                case "7":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    //funcion dollar donde almacena todas la funciones
    static void dollar()
    {
        string igual = "La convension que acaba de hacer se mostrara el mismo resultado\n";
        string resul = "El valor que ingresaste es: ";
        do
        {
            double pd, d, e;
            Console.Clear();
            Console.Write("||====================================||\n");
            Console.Write("||         CONVERSOR DE DOLLAR        ||\n");
            menumoneda();
            Console.WriteLine("Elige a que moneda quiere convertir el dollar");
            var opcion = (Console.ReadLine());

            switch (opcion)
            {

                case "1":
                    Console.Write("Ingrese la cantida de Dollar: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    pd = Math.Floor(d * 55.0075);
                    Console.WriteLine("La conversion de " + d + " Dollar a Peso Dominicano es: " + pd);
                    continuar();
                    break;

                case "2":
                    Console.Write("Ingrese la cantida de Dollar: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.Write(igual);
                    Console.WriteLine(resul + d);
                    continuar();
                    break;

                case "3":
                    Console.Write("Ingrese la cantida de Dollar: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    e = (d * 0.918622);
                    Console.WriteLine("La conversion de " + d + " Dollar a Euro es: " + e);
                    continuar();
                    break;

                case "4":
                    Console.Write("Ingrese la cantida de Dollar: \n");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    Console.WriteLine(resul + d);
                    pd = Math.Floor(d * 55.0075);
                    e = (d * 0.918622);
                    Console.WriteLine("La conversion de " + d + " Dollar a Peso Dominicano es: " + pd);
                    Console.WriteLine("La conversion de " + d + " Dollar a Euro es: " + e);
                    continuar();
                    break;

                case "5":
                    paisdollar();
                    break;

                case "6":
                    moneda();
                    break;

                case "7":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    //funcion de euro donde mostrara todos los datos almacenado
    static void euro()
    {
        string igual = "La convension que acaba de hacer se mostrara el mismo resultado\n";
        string resul = "El valor que ingresaste es: ";
        do
        {
            double pd, d, e;
            Console.Clear();
            Console.Write("||====================================||\n");
            Console.Write("||          CONVERSOR DE EURO         ||\n");
            menumoneda();
            Console.WriteLine("Elige a que moneda quiere convertir el euro");
            var opcion = (Console.ReadLine());

            switch (opcion)
            {

                case "1":
                    Console.Write("Ingrese la cantida de Euro: ");
                    e = Convert.ToDouble(Console.ReadLine());
                    pd = Math.Floor(e * 59.8796);
                    Console.WriteLine("La conversion de " + e + " Euro a Peso Dominicano es: " + pd);
                    continuar();
                    break;

                case "2":
                    Console.Write("Ingrese la cantida de Euro: ");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    d = (e * 1.0886);
                    Console.WriteLine("La conversion de " + e + " Euro a Dollar es: " + d);
                    continuar();
                    break;

                case "3":
                    Console.Write("Ingrese la cantida de Euro: ");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.Write(igual);
                    Console.WriteLine(resul + e);
                    continuar();
                    break;

                case "4":
                    Console.Write("Ingrese la cantida de Euro: \n");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.ReadKey();
                    Console.WriteLine(resul + e);
                    pd = Math.Floor(e * 59.8796);
                    d = (e * 1.0886);
                    Console.WriteLine("La conversion de " + e + " Euro a Peso Dominicano es: " + pd);
                    Console.WriteLine("La conversion de " + e + " Euro a Dollar es: " + d);
                    continuar();
                    break;

                case "5":
                    paiseuro();
                    break;

                case "6":
                    moneda();
                    break;

                case "7":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Seleccionaste una opcion invalidad");
                    break;
            }
        } while (true);
    }

    static void paisdp()
    {
        do
        {

            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("||              País            ||        MONEDA        ||         Región        ||");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("||     República Dominicana     ||    PESO DOMINICANO   ||       El Caribe       ||");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("(1).Para mantener el programa (2).Para volver (3).Para salir");
            var opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "1":
                    break;

                case "2":
                    pesodominicano();
                    break;

                case "3":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    break;
            }
            continuar();

        } while (true);
    }

    static void paisdollar()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("||                    PAÍS                      ||        MONEDA        ||           REGIÓN        ||");
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("||     Islas Vírgenes (UK)                      ||        DOLLAR        ||         El Caribe       ||");
            Console.WriteLine("||     Samoa Americana                          ||        DOLLAR        ||         Polinesia       ||");
            Console.WriteLine("||     Ecuador                                  ||        DOLLAR        ||         Sudamérica      ||");
            Console.WriteLine("||     El Salvador                              ||        DOLLAR        ||         América Central ||");
            Console.WriteLine("||     Guam                                     ||        DOLLAR        ||         Micronesia      ||");
            Console.WriteLine("||     Timor Oriental                           ||        DOLLAR        ||         Sudeste Asiático||");
            Console.WriteLine("||     Islas Marshall                           ||        DOLLAR        ||         Micronesia      ||");
            Console.WriteLine("||     Estados Federados de Micronesia          ||        DOLLAR        ||         Micronesia      ||");
            Console.WriteLine("||     Palaos                                   ||        DOLLAR        ||         Micronesia      ||");
            Console.WriteLine("||     Islas Marianas del Norte                 ||        DOLLAR        ||         Micronesia      ||");
            Console.WriteLine("||     Puerto Rico                              ||        DOLLAR        ||         El Caribe       ||");
            Console.WriteLine("||     Islas Turcas y Caicos                    ||        DOLLAR        ||         El Caribe       ||");
            Console.WriteLine("||     Estados Unidos                           ||        DOLLAR        ||         Norteamérica    ||");
            Console.WriteLine("||     Islas Vírgenes Americanas                ||        DOLLAR        ||         El Caribe       ||");
            Console.WriteLine("||     Territorio Británico del Océano Índico   ||        DOLLAR        ||         Este de África  ||");
            Console.WriteLine("||     Bonaire, San Eustaquio y Saba            ||        DOLLAR        ||         El Caribe       ||");
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("(1).Para mantener el programa (2).Para volver (3).Para salir");
            var opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "1":
                    break;

                case "2":
                    dollar();
                    break;

                case "3":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    break;
            }

        } while (true);
    }

    static void paiseuro()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("||                    PAÍS                      ||        MONEDA        ||           REGIÓN        ||");
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("||       Países Bajos                           ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       Andorra                                ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Bélgica                                ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       España                                 ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Guadalupe                              ||         EURO         ||      El Caribe          ||");
            Console.WriteLine("||       Irlanda                                ||         EURO         ||      Europa del Norte   ||");
            Console.WriteLine("||       Italia                                 ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Austria                                ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       Grecia                                 ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Chipre                                 ||         EURO         ||      Cerca de Asia      ||");
            Console.WriteLine("||       Letonia                                ||         EURO         ||      Europa del Norte   ||");
            Console.WriteLine("||       Lituania                               ||         EURO         ||      Europa del Norte   ||");
            Console.WriteLine("||       Luxemburgo                             ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       Malta                                  ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Martinica                              ||         EURO         ||      El Caribe          ||");
            Console.WriteLine("||       Mayotte                                ||         EURO         ||      Este de África     ||");
            Console.WriteLine("||       Principado de Mónaco                   ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       Portugal                               ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Francia                                ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       Guayana Francesa                       ||         EURO         ||      Sudamérica         ||");
            Console.WriteLine("||       Reunión                                ||         EURO         ||      Este de África     ||");
            Console.WriteLine("||       San Pedro y Miquelón                   ||         EURO         ||      Norteamérica       ||");
            Console.WriteLine("||       Alemania                               ||         EURO         ||      Europa Occidental  ||");
            Console.WriteLine("||       San Marino                             ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Eslovaquia                             ||         EURO         ||      Europa del Este    ||");
            Console.WriteLine("||       Eslovenia                              ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Finlandia                              ||         EURO         ||      Europa del Norte   ||");
            Console.WriteLine("||       Ciudad del Vaticano                    ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Estonia                                ||         EURO         ||      Europa del Norte   ||");
            Console.WriteLine("||       Montenegro                             ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       San Bartolomé                          ||         EURO         ||      El Caribe          ||");
            Console.WriteLine("||       Kosovo                                 ||         EURO         ||      Europa Meridional  ||");
            Console.WriteLine("||       Islas Åland                            ||         EURO         ||      Europa del Norte   ||");
            Console.WriteLine("||       Isla de San Martín                     ||         EURO         ||      El Caribe          ||");
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("(1).Para mantener el programa (2).Para volver (3).Para salir");
            var opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "1":
                    break;

                case "2":
                    euro();
                    break;

                case "3":
                    continuar();
                    Environment.Exit(1);
                    break;

                default:
                    break;
            }

        } while (true);
    }
}