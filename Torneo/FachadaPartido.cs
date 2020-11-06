using System;
using System.Collections.Generic;

namespace linq.Torneo
{
    public class FachadaPartido
    {
        #region Methods
        public void ComenzarPartido( Partido p )
        {
            RepositorioDatos Datos = new RepositorioDatos();
            List<Seleccion> Selecciones = Datos.Selecciones;
        }

        public void FinalizarPartido( Partido p )
        {

        }
        #endregion Methods
    }
}