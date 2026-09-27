namespace ColasComoArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas pila = new Colas(10);

            pila.Agregar("A");
            pila.Agregar("B");
            pila.Agregar("C");

            Console.WriteLine(pila.Obtenerdatos());

            pila.Agregar("D");
            Console.WriteLine(pila.Obtenerdatos());

            pila.Eliminar();
            Console.WriteLine(pila.Obtenerdatos());

            pila.Eliminar();
            Console.WriteLine(pila.Obtenerdatos());
        }
    }
}

