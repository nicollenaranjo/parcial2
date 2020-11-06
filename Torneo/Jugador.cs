using Newtonsoft.Json;

namespace linq.Torneo
{
    public class Jugador
    {
        #region Properties  
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("edad")]
        public int Edad { get; set; }
        
        [JsonIgnore]
        public int Posicion { get; set; }

        [JsonProperty("ataque")]
        public int Ataque { get; set; }

        [JsonProperty("defensa")]
        public int Defensa { get; set; }

        [JsonProperty("goles")]
        public int Goles { get; set; }

        [JsonProperty("asistencias")]
        public int Asistencias { get; set; }

        [JsonProperty("sanciones")]
        public int Sanciones { get; set; }


        #endregion Properties

        #region Initialize
        public Jugador(string n, int e, int p, int a, int d, int g, int s) 
        {
            this.Nombre = n;
            this.Edad = e;
            this.Posicion = p;
            this.Ataque = a;
            this.Defensa = d;
            this.Goles = g;
            this.Asistencias = s;
            this.Sanciones = 0;
        }
        #endregion Initialize

    }
}