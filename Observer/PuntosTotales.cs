using linq.Torneo;
using System;

namespace Observer
{
    public class PuntosTotales : IObserverPartidos
    {
        public void update(Partido p)
        {
            Console.WriteLine("El numero de puntos totales de {0} es: {1} ", p.EquipoLocal.Seleccion.Nombre, p.EquipoLocal.Seleccion.PuntosTotales);
            Console.WriteLine("El numero de puntos totales de {0} es: {1}", p.EquipoVisitante.Seleccion.Nombre, p.EquipoVisitante.Seleccion.PuntosTotales);            
        }
    }
}