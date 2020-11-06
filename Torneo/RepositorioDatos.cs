using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System;
using System.IO;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class RepositorioDatos
    {
        #region Properties  
        [JsonProperty("nombreSeleccion")]
        public List<Seleccion> Selecciones { get; set; }
        
        #endregion Properties

        #region Initialize
        public RepositorioDatos()
        {
            Selecciones = CrearSelecciones();
        }
        #endregion Initialize


        #region Methods

        public void crearSeleccionJson(string n, List<Jugador> jugadores)
        {
            foreach( Seleccion s in Selecciones )
            {
                if( s.Nombre == n )
                {
                    ErrorName ex = new ErrorName(n);
                    ex.name = n;
                    throw ex;
                }
            }
            if(jugadores.Count != 11)
            {
                ErrorNumber ex = new ErrorNumber(jugadores.Count);
                ex.num = jugadores.Count;
                throw ex;
            }
            Seleccion s1 = new Seleccion();
            s1.Nombre = n;
            s1.Jugadores = jugadores;
            Selecciones.Add(s1);
            String output = JsonConvert.SerializeObject(s1);
            File.WriteAllText("./seleccion" + n + ".json", output);
            Seleccion SeleccionDeserializada = JsonConvert.DeserializeObject<Seleccion>(output);
            String jugadoresSeleccionCreadaSerializados = JsonConvert.SerializeObject(s1.Jugadores);
            File.WriteAllText("./jugadoresCreada" + n + ".json", jugadoresSeleccionCreadaSerializados);
        }

        private List<Seleccion> CrearSelecciones()
        {
            List<Seleccion> selecciones = new List<Seleccion>();
            selecciones.Add(new Seleccion()
            {
                Nombre = "Francia",
                Jugadores = new List<Jugador>()
                {
                    new Jugador("Griezmann", 28, 11, 90, 55, 10, 2),
                    new Jugador("Benzema", 32, 9, 92, 40, 20, 1),
                    new Jugador("Mbappe", 21, 7, 95, 50, 15, 14),
                    new Jugador("Dembelé", 23, 10, 92, 45, 12, 17),
                    new Jugador("Pogba", 30, 8, 93, 56, 15, 9),
                    new Jugador("Griezmann", 25, 13, 91, 39, 16, 11),
                    new Jugador("Giroud", 24, 7, 96, 42, 11, 13),
                    new Jugador("Camavinga", 27, 6, 94, 40, 12, 5),
                    new Jugador("Pavard", 30, 2, 90, 35, 15, 13),
                    new Jugador("Upamecano", 32, 85, 95, 38, 9, 2),
                    new Jugador("Lloris", 25, 3, 94, 45, 10, 3),
                }
            });
            selecciones.Add(new Seleccion()
            {
                Nombre = "España",
                Jugadores = new List<Jugador>()
                {
                    new Jugador("Ramos", 33, 6, 60, 85, 8, 0),
                    new Jugador("Fati", 17, 9, 95, 40, 10, 12),
                    new Jugador("Aspas", 32, 11, 85, 55, 5, 5),
                    new Jugador("Busquets", 33, 5, 79, 85, 2, 3),
                    new Jugador("Torres", 30, 8, 93, 56, 15, 9),
                    new Jugador("Diarra", 25, 13, 91, 39, 16, 11),
                    new Jugador("Alcantara", 24, 7, 96, 42, 11, 13),
                    new Jugador("Navas", 27, 6, 94, 40, 12, 5),
                    new Jugador("Olmo", 30, 2, 90, 35, 15, 13),
                    new Jugador("Morata", 32, 85, 95, 38, 9, 2),
                    new Jugador("Reguilon", 25, 3, 94, 45, 10, 3),
                }
            });
            selecciones.Add(new Seleccion()
            {
                Nombre = "Colombia",
                Jugadores = new List<Jugador>()
                {
                    new Jugador("Falcao", 33, 9, 89, 50, 9, 2),
                    new Jugador("James", 29, 10, 97, 45, 7, 17),
                    new Jugador("Ospina", 31, 1, 40, 95, 0, 0),
                    new Jugador("Mina", 24, 2, 55, 89, 4, 0),
                    new Jugador("Cuadrado", 30, 8, 93, 56, 15, 9),
                    new Jugador("Arias", 25, 13, 91, 39, 16, 11),
                    new Jugador("Zapata", 24, 7, 96, 42, 11, 13),
                    new Jugador("Alzate", 27, 6, 94, 40, 12, 5),
                    new Jugador("Lerma", 30, 2, 90, 35, 15, 13),
                    new Jugador("Mojica", 32, 85, 95, 38, 9, 2),
                    new Jugador("Murillo", 25, 3, 94, 45, 10, 3),
                }
            });
            selecciones.Add(new Seleccion()
            {
                Nombre = "Argentina",
                Jugadores = new List<Jugador>()
                {
                    new Jugador("Messi", 33, 10, 99, 50, 40, 20),
                    new Jugador("Aguero", 32, 9, 90, 50, 10, 5),
                    new Jugador("Acuña", 24, 4, 75, 85, 3, 10),
                    new Jugador("Dybala", 25, 7, 90, 45, 8, 6),
                    new Jugador("Aguero", 30, 8, 93, 56, 15, 9),
                    new Jugador("Martinez", 25, 13, 91, 39, 16, 11),
                    new Jugador("Paredes", 24, 7, 96, 42, 11, 13),
                    new Jugador("Armani", 27, 6, 94, 40, 12, 5),
                    new Jugador("Otamendi", 30, 2, 90, 35, 15, 13),
                    new Jugador("Andrada", 32, 85, 95, 38, 9, 2),
                    new Jugador("Tagliafico", 25, 3, 94, 45, 10, 3),
                }
            });
            selecciones.Add(new Seleccion()
            {
                Nombre = "Italia",
                Jugadores = new List<Jugador>()
                {
                    new Jugador("Immobile", 33, 10, 99, 50, 40, 20),
                    new Jugador("Zaniolo", 32, 9, 90, 50, 10, 5),
                    new Jugador("Kean", 24, 4, 75, 85, 3, 10),
                    new Jugador("Insigne", 25, 7, 90, 45, 8, 6),
                    new Jugador("Chiellini", 30, 8, 93, 56, 15, 9),
                    new Jugador("Tonali", 25, 13, 91, 39, 16, 11),
                    new Jugador("Barella", 24, 7, 96, 42, 11, 13),
                    new Jugador("Donnarumma", 27, 6, 94, 40, 12, 5),
                    new Jugador("Bonucci", 30, 2, 90, 35, 15, 13),
                    new Jugador("Locatelli", 32, 85, 95, 38, 9, 2),
                    new Jugador("Caputo", 25, 3, 94, 45, 10, 3),
                }
            });

            return selecciones;
        }
        #endregion Methods
    }
}