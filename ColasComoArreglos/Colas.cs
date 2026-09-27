using System.Text;

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

        public void Eliminar()
        {
            // si la cola esta vacia , no se elimina nada y se sale
            if (_tope == 0)
            {
                throw new Exception("La cola esta vacia");
            }
            // inicializa un for que empieza en un numero antes de el tope 
            // mueve todos los elementos a la izquierda , 
            //eliminando el primer elemento como una cola 
            for (int contador = 0; contador < _tope - 1; contador++)
            {
                _cola[contador] = _cola[contador + 1];
            }
            _tope--;
            _cola[_tope] = string.Empty;
        }

        public string Obtenerdatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < _tope; i++)
            {
                datos.AppendLine(_cola[i]);
            }
            return datos.ToString();
        }

    }
}
