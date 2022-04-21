public class Events : AgendaElectronica
{

    #region "Properties"
    public string? Fecha { get; set; }
    public object? Hora { get; set; }
    public string? Lugar { get; set; }
    #endregion

    #region "Constructores"
    public Events(string nombre, string apellido, string telefono,
    string direccion, string email)
    {
        this.Nombre = apellido;
        this.Fecha = telefono;
        this.Hora = direccion;
        this.Lugar = email;
    }

    public Events()
    {

    }
    #endregion

    #region "Metodos operacionales"

    public void Buscar(string nameEvento)
    {
        Console.Clear();

        var consulta = "select * from events where lower(name) = $name";

        var events = Buscar("events", consulta, nameEvento);

        do
        {
            MenuEdicion(events);
        } while (true);
    }

    public void Agregar(string nameTable, List<string> lista)
    {
        Console.Clear();

        var consulta = "insert into events (name, fecha, hora, lugar)";
        consulta += " values ($n, $f, $h, $l)";

        if (base.Agregar(nameTable, consulta, lista))
        {
            Console.WriteLine("Evento agregado correctamente. Presione una tecla para continuar.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("El evento no fue agregado. Presione una tecla para continuar.");
            Console.ReadKey();
        }
    }

    public void Eliminar(string nameTable, string id, List<List<string>> events)
    {
        var option = "";
        do
        {
            Console.Clear();

            MenuPersonalizado(events);

            Console.WriteLine("\nDeseas eliminarlo?, recuerda esta accion no se deshace [S] SI o [N] NO");
            option = Console.ReadLine()!.Trim().ToLower();

            if (option == "s")
            {
                Console.Clear();
                var consulta = "delete from events where idEvents = @id";
                if (base.Borrar(nameTable, id, consulta))
                {
                    Console.WriteLine("El evento fue eliminado correctamente. presione una tecla para continuar.");
                    Console.ReadKey();
                    Utilidades.GestionarEventos();
                }
                else
                {
                    Console.WriteLine("Evento no fue eliminado. Presione una tecla para continuar.");
                    Console.ReadKey();
                    Utilidades.GestionarEventos();
                }
            }
            if (option == "n")
            {
                MenuEdicion(events);
            }
        } while (option != "s" || option != "n");
    }

    public void Editar(string nameTable, string id, List<List<string>> events)
    {
        var option = "";

        do
        {
            Console.Clear();

            Console.WriteLine("Que deseas modificar del evento.\n\n1. Name\n2. Fecha\n3. Hora\n4. Lugar\n5. No modificar");

            option = Console.ReadLine();
            var pos = 0;
            for (var i = 0; i < events.Count; i++)
            {
                if (events[i][0] == id)
                {
                    pos = i;
                }
            };

            switch (option)
            {
                case "1":
                    Console.Write("Ingrese el name: ");
                    events[pos][1] = Console.ReadLine()!;
                    break;
                case "2":
                    Console.Write("Ingrese la fecha: ");
                    events[pos][2] = Console.ReadLine()!;
                    break;
                case "3":
                    Console.Write("Ingrese la hora: ");
                    events[pos][3] = Console.ReadLine()!;
                    break;
                case "4":
                    Console.Write("Ingrese el lugar: ");
                    events[pos][4] = Console.ReadLine()!;
                    break;
                case "5":
                    Utilidades.GestionarEventos();
                    break;
            }
        } while (option != "1" && option != "2" && option != "3" &&
         option != "4" && option != "5");

        Console.Clear();

        var consulta = @"
        update events
        set name = $1, fecha = $2, hora = $3, lugar = $4
        where idEvents = $5";

        if (base.Editar(nameTable, id, consulta, events))
        {
            Console.WriteLine("evento editado correctamente. Presione una tecla para continuar.");
            Console.ReadKey();
            Utilidades.GestionarEventos();
        }
        else
        {
            Console.WriteLine("evento no fue editado. Presione una tecla para continuar.");
            Console.ReadKey();
            Utilidades.GestionarEventos();
        }
    }
    #endregion

    public void MenuEdicion(List<List<string>> events)
    {
        Console.Clear();

        if (events.Count == 0)
        {
            Console.WriteLine("No se encontro ningun evento. presione una tecla para continuar.");
            Console.ReadKey();
            Utilidades.GestionarEventos();
        }

        MenuPersonalizado(events);

        Console.WriteLine("\nSeleccione la option deseada a continuación.");
        Console.WriteLine("\n1. Editar\n2. Eliminar\n3. Atras\n4. Salir");

        var option = Console.ReadLine();
        var id = "";
        switch (option)
        {
            case "1":
                ValidarId(out id, events);
                Editar("events", id, events);
                break;
            case "2":
                ValidarId(out id, events);
                Eliminar("events", id, events);
                break;
            case "3":
                Utilidades.GestionarEventos();
                break;
            case "4":
                Utilidades.Salir();
                break;
        }
    }

    private void ValidarId(out string id, List<List<string>> events)
    {
        var tag = true;
        do
        {
            Console.Clear();

            MenuPersonalizado(events);

            Console.WriteLine("\nAhora seleccione el evento por su (Id) de la primera columna.");
            id = Console.ReadLine()!;
            foreach (var key in events)
            {
                if (key[0] == id)
                {
                    tag = false;
                    break;
                }
            }

            if (tag)
            {
                Console.Clear();
                Console.WriteLine("Debes ingresar un (id) valido. intente nuevamente presione una tecla.");
                Console.ReadKey();
            }

        } while (tag);
    }

    public void DatosAlmacenados(string nameTable)
    {
        var consulta = "select * from events";
        var events = base.Buscar(nameTable, consulta);

        do
        {
            MenuEdicion(events);
        } while (true);
    }

    void MenuPersonalizado(List<List<string>> events)
    {
        Console.WriteLine($"ID{"",10}Name{"",16}Date{"",16}Time{"",10}place{"",21}");
        Console.WriteLine($"----------  ------------------  ------------------  ------------  ----------------------------");

        for (var i = 0; i < events.Count; i++)
        {
            if (i % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{events[i][0],-12}{events[i][1],-20}{events[i][2],-20}{events[i][3],-14}{events[i][4],-30}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{events[i][0],-12}{events[i][1],-20}{events[i][2],-20}{events[i][3],-14}{events[i][4],-30}");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}