using System;

namespace Excepciones.CustomExceptions
{
    public class ErrorSameName : Exception
    {
        public ErrorSameName() { }
        public ErrorSameName(string n) : base(String.Format("El nombre del equipo local: {0}, es el mismo que el de visitante", n )) { }
        public string nombre {get; set;}
    }
}