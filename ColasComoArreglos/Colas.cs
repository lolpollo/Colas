namespace ColasComoArreglos
{
    internal class Colas
    {
        string[] _cola;
        int _tope;

        public Colas(int elementos)
        {

            _cola = new string[elementos];
            _tope = 0;


        }

        public void Agregar(string dato)
        {
            if (_tope == _cola.Length)
            {
                throw new Exception("La Cola se lleno");
            }
            _cola[_tope] = dato;
            _tope++;

        }

        public string Eliminar()

        {
            if (_tope == 0)
            {
                throw new Exception("La cola esta vacia");
            }
            _tope--;
            _cola[_tope] = string.Empty;
        }


    }
}
