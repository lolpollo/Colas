namespace ColasComoArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas cola = new Colas(10);

            cola.Agregar("A");
            cola.Agregar("B");
            cola.Agregar("C");

            Console.WriteLine(cola.Obtenerdatos());

            cola.Agregar("D");
            Console.WriteLine(cola.Obtenerdatos());

            cola.Eliminar();
            Console.WriteLine(cola.Obtenerdatos());

            cola.Agregar("E");
            Console.WriteLine(cola.Obtenerdatos());

            cola.Eliminar();
            Console.WriteLine(cola.Obtenerdatos());

            cola.Agregar("F");
            Console.WriteLine(cola.Obtenerdatos());

            cola.Eliminar();
            Console.WriteLine(cola.Obtenerdatos());

            cola.Agregar("G");
            Console.WriteLine(cola.Obtenerdatos());

            cola.Eliminar();
            Console.WriteLine(cola.Obtenerdatos());

            cola.Agregar("H");
            Console.WriteLine(cola.Obtenerdatos());
        }
    }
}

