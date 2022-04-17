public class CalculadoraBasica
{
    public static void Calculadora()
    {
        Console.WriteLine("_CALCULARORA_");
        Console.WriteLine("_----------------------------------------------------------------------_");

        Console.Write("_ Introduzca un número: ");
        var valor = Console.ReadLine()!;
        float n1 = float.Parse(valor != "" ? valor : "0");
        Console.Write("_ Introduzca otro número: "); float n2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("_----------------------------------------------------------------------_");
        Console.WriteLine(" [1]Sumar [2]Restar [3]Multiplicar [4]Dividir ");
        Console.WriteLine("_----------------------------------------------------------------------_");
        Console.WriteLine("");
        Console.Write("Por favor introduzca la opción  deseada: "); int op = int.Parse(Console.ReadLine()!);
        switch (op)
        {
            case 1:
                Console.WriteLine(n1 + "+" + n2 + " = " + (n1 + n2));
                break;

            case 2:
                Console.WriteLine(n1 + "-" + n2 + " = " + (n1 - n2));
                break;

            case 3:
                Console.WriteLine(n1 + "*" + n2 + " = " + (n1 * n2));
                break;

            case 4:
                if (n2 != 0)
                {
                    Console.WriteLine(n1 + "/" + n2 + " = " + (n1 / n2));
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre 0");
                }
                break;

            default:
                Console.WriteLine("Por favor introduzca una opción valida: ");
                break;
        }

        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
        Principal.MenuPrincipal();
    }
}