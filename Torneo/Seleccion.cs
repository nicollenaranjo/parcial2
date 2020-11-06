using System.Collections.Generic;
using Newtonsoft.Json;

namespace linq.Torneo
{
    public class Seleccion
    {
        #region Properties  
        [JsonProperty("nombreSeleccion")]
        public string Nombre { get; set; }

        [JsonProperty("puntos")]
        public int PuntosTotales { get; set; }

        [JsonProperty("goles")]
        public int GolesTotales { get; set; }

        [JsonProperty("asistencias")]
        public int AsistenciasTotales { get; set; }

        [JsonProperty("jugadores")]
        public List<Jugador> Jugadores { get; set; }

        #endregion Properties

        #region Initialize
        public Seleccion()
        {
            Nombre = "";
            PuntosTotales = 0;
            GolesTotales = 0;
            AsistenciasTotales = 0;
            Jugadores = new List<Jugador>();
        }

        #endregion Initialize

    }
}