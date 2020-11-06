using linq.Torneo;
using System;

namespace Observer
{
    public class GolesTotales : IObserverPartidos
    {
        public void update(Partido p)
        {
            Console.WriteLine("El numero de goles totales de {0} es: {1} ", p.EquipoLocal.Seleccion.Nombre, p.EquipoLocal.Goles);
            Console.WriteLine("El numero de goles totales de {0} es: {1}", p.EquipoVisitante.Seleccion.Nombre, p.EquipoVisitante.Goles);
        }
    }
}
