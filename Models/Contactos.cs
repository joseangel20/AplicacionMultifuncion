public class Contactos : AgendaElectronica
{
    #region "Constructores"
    public Contactos(string nombre, string apellido, string telefono,
    string direccion, string email)
    {
        this.Apellido = apellido;
        this.Telefono = telefono;
        this.Direccion = direccion;
        this.Email = email;
    }

    public Contactos()
    {

    }
    #endregion

    #region "Properties"
    public string? Apellido { get; set; }
    public string? Telefono { get; set; }
    public object? Direccion { get; set; }
    public string? Email { get; set; }
    #endregion

    #region "Metodos operacionales"

    public void Buscar(string nameContact)
    {
        Console.Clear();

        var consulta = "select * from contacts where lower(name) = $name";

        var contacts = Buscar("contacts", consulta, nameContact);

        do
        {
            MenuEdicion(contacts);
        } while (true);
    }

    public void Agregar(string nameTable, List<string> lista)
    {
        Console.Clear();
        var consulta = "insert into contacts (name, apellido, phone, direccion, email)";
        consulta += " values ($n, $a, $p, $d, $e)";

        if (base.Agregar(nameTable, consulta, lista))
        {
            Console.WriteLine("Contacto agregado correctamente. Presione una tecla para continuar.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("El contacto no fue agregado. Presione una tecla para continuar.");
            Console.ReadKey();
        }
    }

    public void Eliminar(string nameTable, string id, List<List<string>> contacts)
    {
        var option = "";
        do
        {
            Console.Clear();

            MenuPersonalizado(contacts);

            Console.WriteLine("\nDeseas eliminarlo?, recuerda esta accion no se deshace [S] SI o [N] NO");
            option = Console.ReadLine()!.Trim().ToLower();

            if (option == "s")
            {
                Console.Clear();
                var consulta = "delete from contacts where idContacts = @id";
                if (base.Borrar(nameTable, id, consulta))
                {
                    Console.WriteLine("El contacto fue eliminado correctamente. presione una tecla para continuar.");
                    Console.ReadKey();
                    Utilidades.GestionarContactos();
                }
                else
                {
                    Console.WriteLine("Contacto no fue eliminado. Presione una tecla para continuar.");
                    Console.ReadKey();
                    Utilidades.GestionarContactos();
                }
            }
            if (option == "n")
            {
                MenuEdicion(contacts);
            }
        } while (option != "s" || option != "n");
    }

    public void Editar(string nameTable, string id, List<List<string>> contacts)
    {
        var option = "";

        do
        {
            Console.Clear();

            Console.WriteLine("Que deseas modificar del contacto.\n\n1. nombre\n2. apellido\n3. telefono\n4. direccion\n5. email\n6. No modificar");

            option = Console.ReadLine();
            var pos = 0;
            for (var i = 0; i < contacts.Count; i++)
            {
                if (contacts[i][0] == id)
                {
                    pos = i;
                }
            };

            switch (option)
            {
                case "1":
                    Console.Write("Ingrese el name: ");
                    contacts[pos][1] = Console.ReadLine()!;
                    break;
                case "2":
                    Console.Write("Ingrese el lastname: ");
                    contacts[pos][2] = Console.ReadLine()!;
                    break;
                case "3":
                    Console.Write("Ingrese el phone: ");
                    contacts[pos][3] = Console.ReadLine()!;
                    break;
                case "4":
                    Console.Write("Ingrese la direccion: ");
                    contacts[pos][4] = Console.ReadLine()!;
                    break;
                case "5":
                    Console.Write("Ingrese el email: ");
                    contacts[pos][5] = Console.ReadLine()!;
                    break;
                case "6":
                    Utilidades.GestionarContactos();
                    break;
            }
        } while (option != "1" && option != "2" && option != "3" &&
         option != "4" && option != "5" && option != "6");

        Console.Clear();

        var consulta = @"
        update contacts
        set name = $1, apellido = $2, phone = $3, direccion = $4, email = $5
        where idContacts = $6";

        if (base.Editar(nameTable, id, consulta, contacts))
        {
            Console.WriteLine("Contacto editado correctamente. Presione una tecla para continuar.");
            Console.ReadKey();
            Utilidades.GestionarContactos();
        }
        else
        {
            Console.WriteLine("Contacto no fue editado. Presione una tecla para continuar.");
            Console.ReadKey();
            Utilidades.GestionarContactos();
        }
    }
    #endregion

    public void MenuEdicion(List<List<string>> contacts)
    {
        Console.Clear();

        if (contacts.Count == 0)
        {
            Console.WriteLine("No se encontro ningun contacto. presione una tecla para continuar.");
            Console.ReadKey();
            Utilidades.GestionarContactos();
        }

        MenuPersonalizado(contacts);

        Console.WriteLine("\nSeleccione la option deseada a continuación.");
        Console.WriteLine("\n1. Editar\n2. Eliminar\n3. Atras\n4. Salir");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                var id1 = "";
                ValidarId(out id1, contacts);
                Editar("contacts", id1, contacts);
                break;
            case "2":
                var id2 = "";
                ValidarId(out id2, contacts);
                Eliminar("contacts", id2, contacts);
                break;
            case "3":
                Utilidades.GestionarContactos();
                break;
            case "4":
                Utilidades.Salir();
                break;
        }
    }

    private void ValidarId(out string id, List<List<string>> contacts)
    {
        var tag = true;
        do
        {
            Console.Clear();

            MenuPersonalizado(contacts);

            Console.WriteLine("\nAhora seleccione el contacto por su (Id) de la primera columna.");
            id = Console.ReadLine()!;
            foreach (var key in contacts)
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
        var consulta = "select * from contacts";
        var contacts = base.Buscar(nameTable, consulta);

        do
        {
            MenuEdicion(contacts);
        } while (true);
    }

    void MenuPersonalizado(List<List<string>> contacts)
    {
        Console.WriteLine($"ID{"",10}Name{"",16}LastName{"",12}Phone{"",9}Direccion{"",21}email{"",25}");
        Console.WriteLine($"----------  ------------------  ------------------  ------------  ----------------------------  ------------------------------");

        for (var i = 0; i < contacts.Count; i++)
        {
            if (i % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{contacts[i][0],-12}{contacts[i][1],-20}{contacts[i][2],-20}{contacts[i][3],-14}{contacts[i][4],-30}{contacts[i][5],0}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{contacts[i][0],-12}{contacts[i][1],-20}{contacts[i][2],-20}{contacts[i][3],-14}{contacts[i][4],-30}{contacts[i][5],0}");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}