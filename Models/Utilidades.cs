public class Utilidades
{
    public static void GestionarContactos()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione una de las siguienes opciones.");
            Console.WriteLine("\n1. Agenda electronica\n2. Buscar un contacto\n3. Agregar un contacto\n4. Contactos guardados\n5. Salir");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Principal.AgendaElectronica();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ingrese el name del contacto a buscar.");
                    var nameContact = Console.ReadLine()?.Trim().ToLower()!;

                    new Contactos().Buscar(nameContact);
                    break;
                case "3":
                    Console.Write("Ingrese el name: ");
                    var name = Console.ReadLine();
                    Console.Write("Ingrese el lastName: ");
                    var lastName = Console.ReadLine();
                    Console.Write("Ingrese el phone: ");
                    var phone = Console.ReadLine();
                    Console.Write("Ingrese el direccion: ");
                    var direccion = Console.ReadLine();
                    Console.Write("Ingrese el email: ");
                    var email = Console.ReadLine();

                    if (name != null && lastName != null && phone != null &&
                     direccion != null && email != null)
                    {
                        new Contactos().Agregar("contacts", new List<string>() { name, lastName, phone, direccion, email });
                    }
                    break;
                case "4":
                    new Contactos().DatosAlmacenados("contacts");
                    break;
                case "5":
                    Salir();
                    break;
            }
        } while (true);
    }

    public static void GestionarEventos()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione una de las siguienes opciones.");
            Console.WriteLine("\n1. Agenda electronica\n2. Buscar un evento\n3. Agregar un evento\n4. Eventos guardados\n5. Salir");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Principal.AgendaElectronica();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ingrese el name del evento a buscar.");
                    var nameEvento = Console.ReadLine()?.Trim().ToLower()!;

                    new Events().Buscar(nameEvento);
                    break;
                case "3":
                    Console.Write("Ingrese el name: ");
                    var name = Console.ReadLine()!;
                    Console.Write("Ingrese el Data: ");
                    var Data = Console.ReadLine()!;
                    Console.Write("Ingrese el time: ");
                    var time = Console.ReadLine()!;
                    Console.Write("Ingrese el place: ");
                    var place = Console.ReadLine()!;

                    new Events().Agregar("events", new List<string>() { name, Data, time, place });

                    break;
                case "4":
                    new Events().DatosAlmacenados("events");
                    break;
                case "5":
                    Salir();
                    break;
            }
        } while (true);
    }

    public static void Salir()
    {
        Console.Clear();
        Console.WriteLine("Gracias por haber estado aqui. presione una tecla para continuar.");
        Console.ReadKey();
        Environment.Exit(0);
    }
}