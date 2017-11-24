using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantasClient.Claces
{
    [JsonObject]
    public class Enfermedades
    {

        [JsonProperty("IdEnfermedad")]
        public int IdEnfermedad { get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("Definicion")]
        public string Definicion { get; set; }
    }

}