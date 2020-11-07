using System;
using linq.Torneo;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace linq.Torneo
{
    public class GestorJson
    {
        #region Initialize
        public GestorJson(Seleccion s1)
        {
            String output = JsonConvert.SerializeObject(s1);
            File.WriteAllText("./seleccion" + s1.Nombre + ".json", output);
            Seleccion SeleccionDeserializada = JsonConvert.DeserializeObject<Seleccion>(output);
            String jugadoresSeleccionCreadaSerializados = JsonConvert.SerializeObject(s1.Jugadores);
            File.WriteAllText("./jugadoresCreada" + s1.Nombre + ".json", jugadoresSeleccionCreadaSerializados);
        }
        #endregion Initialize
    }
}