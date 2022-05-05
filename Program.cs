Principal.MenuPrincipal();
public class Principal
{
    public static void MenuPrincipal()
    {
        #region "Menu Principal"
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;

        // Aqui inicia el programa mostrando un saludo y el menu Principal
        var opcion = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu programa multifunción.");
            Console.WriteLine(@"
1. Agenda electrónica
2. Conversor de unidades
3. Calculadora
4. Salir");

            opcion = Console.ReadLine()?.Trim();

            switch (opcion)
            {
                case "1":
                    AgendaElectronica();
                    break;
                case "2":
                    Conversor.inicio();
                    break;
                case "3":
                    CalculadoraBasica.Calculadora();
                    break;
                case "4":
                    Utilidades.Salir();
                    break;
            }
        } while (opcion != "4");
    }
    #endregion

    public static void AgendaElectronica()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Que deseas realizar en la agenda electronica.");
            Console.WriteLine("\n1. Menu Principal\n2. Gestionar contactos\n3. Gestionar eventos\n4. Salir");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    MenuPrincipal();
                    break;
                case "2":
                    Utilidades.GestionarContactos();
                    break;
                case "3":
                    Utilidades.GestionarEventos();
                    break;
                case "4":
                    Utilidades.Salir();
                    break;
            }
        } while (true);
    }
}