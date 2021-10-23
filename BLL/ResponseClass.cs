using System.Collections.Generic;

namespace BLL
{
    public class ResponseClass<T>
    {

        public ResponseClass(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public ResponseClass(T objeto)
        {
            Error = false;
            Object = objeto;
        }

        public ResponseClass(List<T> objects)
        {
            Error = false;
            Objects = objects;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public T Object { get; set; }
        public List<T> Objects { get; set; }
    }
}