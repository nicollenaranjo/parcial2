using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class Partido
    {
        #region Properties  
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }

        #endregion Properties

        #region Initialize
        public Partido(Seleccion EquipoLocal, Seleccion EquipoVisitante) 
        {
            this.EquipoLocal = new Equipo(EquipoLocal);
            this.EquipoVisitante = new Equipo(EquipoVisitante);
        }
        #endregion Initialize
        
        #region Methods
        private void CalcularExpulsiones()
        {
            EquipoLocal.ExpulsarJugador();
            EquipoVisitante.ExpulsarJugador();
        }

        private void CalcularSanciones()
        {
            EquipoLocal.SancionarJugador();
            EquipoVisitante.SancionarJugador();
        }

        private void CalcularPuntos()
        {
            Random rand = new Random();
            if(EquipoVisitante.Goles > EquipoLocal.Goles )
            {
                EquipoVisitante.Seleccion.PuntosTotales += 3;
            }
            else if(EquipoLocal.Goles > EquipoVisitante.Goles)
            {
                EquipoLocal.Seleccion.PuntosTotales += 3;
            }
            else if(EquipoLocal.Goles == EquipoVisitante.Goles)
            {
                EquipoVisitante.Seleccion.PuntosTotales++;
                EquipoLocal.Seleccion.PuntosTotales++;
            }
        }

        private void CalcularAsistencia()
        {
            foreach (Jugador e in EquipoLocal.Seleccion.Jugadores)
            {
                EquipoLocal.Seleccion.AsistenciasTotales += e.Asistencias;
            }
            foreach (Jugador e in EquipoVisitante.Seleccion.Jugadores)
            {
                EquipoVisitante.Seleccion.AsistenciasTotales += e.Asistencias;
            }
        }

        private string CalcularResultado()
        {
            string resultado = "0 - 0";
            Random random = new Random();
            EquipoLocal.Goles = random.Next(0,6);
            EquipoVisitante.Goles = random.Next(0,6);
            CalcularPuntos();
            resultado = EquipoLocal.Goles.ToString() + " - " + EquipoVisitante.Goles.ToString();
            return resultado;
        }

        public string Resultado()
        {
            string resultado = "0 - 0";
            try
            {
                CalcularSanciones();
                CalcularExpulsiones();
                resultado = CalcularResultado();
            }
            catch(LoseForWException ex)
            {
                Console.WriteLine(ex.Message);
                EquipoLocal.Goles -= EquipoLocal.Goles;
                EquipoVisitante.Goles -= EquipoVisitante.Goles;
                if (ex.NombreEquipo == EquipoLocal.Seleccion.Nombre)
                {
                    EquipoVisitante.Goles += 3;
                    EquipoLocal.Seleccion.PuntosTotales+=3;
                    resultado = "0 - 3";
                }
                else
                {
                    EquipoLocal.Goles += 3;
                    EquipoLocal.Seleccion.PuntosTotales+=3;
                    resultado = "3 - 0";
                }
            }
            
            return resultado;
        }
        #endregion Methods
    }
}