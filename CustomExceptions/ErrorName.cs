using System;

namespace Excepciones.CustomExceptions
{
    public class ErrorName : Exception
    {
        public ErrorName() { }

        public ErrorName(string name) : base(String.Format("La Seleccion {0} ya se encuentra creada", name )) { }

        public string name {get; set;}
    }
}