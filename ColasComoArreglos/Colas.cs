using System.Text;

namespace ColasComoArreglos
{
    internal class Colas
    {
        string[] _cola;
        int _tope;
        int _cantidad;

        int _primero;



        public Colas(int elementos)
        {

            _cola = new string[elementos];
            _primero = 0;
            _tope = 0;
            _cantidad = 0;
        }

        public void Agregar(string dato)
        {

            if (_cantidad == _cola.Length)
            {
                throw new Exception("La Cola se lleno");
            }
            _cola[_tope] = dato;
            _tope++;

            if (_tope == _cola.Length)
            {
                _tope = 0;
            }
            _cantidad++;

        }

        public void Eliminar()
        {

            if (_cantidad == 0)
            {
                throw new Exception("La cola esta vacia");
            }
            _cola[_primero] = string.Empty;
            _primero++;

            if (_primero == _cola.Length)
            {
                _primero = 0;
            }

            _cantidad--;
        }

        public string Obtenerdatos()
        {
            StringBuilder datos = new StringBuilder();
            int indice = _primero;
            for (int i = 0; i < _cantidad; i++)
            {
                datos.AppendLine(_cola[indice]);

                indice++;

                if (indice == _cola.Length)
                {
                    indice = 0;
                }
            }
            return datos.ToString();
        }

    }
}
