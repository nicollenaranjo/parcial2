using System;
using System.Collections.Generic;
using Observer;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class FachadaPartido
    {
        #region Methods
        public Partido ComenzarPartido( Seleccion s, Seleccion s1 )
        {
            if( s.Nombre == s1.Nombre)
            {
                ErrorSameName ex = new ErrorSameName();
                ex.nombre = s.Nombre;
                throw ex;
            }
            Partido p = new Partido(s, s1);
            return p;
        }

        public void FinalizarPartido( Partido p )
        {
            GestorPartido gestor = new GestorPartido(); 
            AsistenciasTotales a = new AsistenciasTotales();
            GolesTotales g = new GolesTotales();
            PuntosTotales pu = new PuntosTotales();
            gestor.Subcribe(a);
            gestor.Subcribe(g);
            gestor.Subcribe(pu);
            gestor.Notify(p);
        }
        #endregion Methods
    }
}