using linq.Torneo;
using System;

namespace Observer
{
    public class AsistenciasTotales : IObserverPartidos
    {
        public void update(Partido p)
        {
            Console.WriteLine("El numero de asistencias totales de {0} es: {1} ", p.EquipoLocal.Seleccion.Nombre, p.EquipoLocal.Seleccion.AsistenciasTotales);
            Console.WriteLine("El numero de asistencias totales de {0} es: {1}", p.EquipoVisitante.Seleccion.Nombre, p.EquipoVisitante.Seleccion.AsistenciasTotales);            
        }
    }
}