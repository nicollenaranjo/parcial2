using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class Equipo
    {
        #region Properties  
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Faltas { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public Seleccion Seleccion { get; set; }
        public bool EsLocal { get; set; }

        #endregion Properties

        #region Initialize
        public Equipo(Seleccion seleccion)
        {
            this.Seleccion = seleccion;
        }
        #endregion Initialize

        #region Methods
        public void ExpulsarJugador()
        {
            Random rand = new Random();
            int j = rand.Next(1,5);
            for( int i = 0; i < j; i++)
            {
                int position = rand.Next(Seleccion.Jugadores.Count);
                Jugador jugadorExpulsado = Seleccion.Jugadores[position];
                TarjetasRojas++;
                if (Seleccion.Jugadores.Count < 7) 
                {
                    LoseForWException ex = new LoseForWException(Seleccion.Nombre);
                    ex.NombreEquipo = Seleccion.Nombre;
                    throw ex;
                }
                Console.WriteLine("Sea expulsado a {0} del la Seleccion {1}", jugadorExpulsado.Nombre, Seleccion.Nombre );
                Seleccion.Jugadores.Remove(jugadorExpulsado);
            }
        }

        public void SancionarJugador()
        {
            Random rand = new Random();
            int j = rand.Next(1,8);
            for(int i = 0; i < j; i++)
            {
                int position = rand.Next(Seleccion.Jugadores.Count);
                Jugador jugadorSancionado = Seleccion.Jugadores[position];
                TarjetasAmarillas++;
                jugadorSancionado.Sanciones++;
                if (Seleccion.Jugadores.Count < 7) 
                {
                    LoseForWException ex = new LoseForWException(Seleccion.Nombre);
                    ex.NombreEquipo = Seleccion.Nombre;
                    throw ex;
                }
                if (jugadorSancionado.Sanciones > 1 ) 
                {
                    TarjetasRojas++;
                    Seleccion.Jugadores.Remove(jugadorSancionado);
                    Console.WriteLine("Sea expulsado a {0} del la Seleccion {1} por tener dos tarjetas amarillas", jugadorSancionado.Nombre, Seleccion.Nombre );
                }
                else
                {
                    Console.WriteLine("Sea sancionado a {0} del la Seleccion {1}", jugadorSancionado.Nombre, Seleccion.Nombre );
                }
            }
        }
        #endregion Methods
    }
}