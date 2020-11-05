using System;

namespace Excepciones.CustomExceptions
{
    public class ErrorNumber : Exception
    {
        public ErrorNumber() { }
        public ErrorNumber(int n) : base(String.Format("El numero de jugadores: {0}, no son los correctos", n )) { }
    }
}