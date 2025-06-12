using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using HipHopMusic.Models;

namespace HipHopMusic.Models
{
    public class Cancion
    {
        public string Nombre { get; set; } = string.Empty;
        public string Imagen { get; set; } = string.Empty;
        public string Anio { get; set; } = string.Empty;
        public string Duracion { get; set; } = string.Empty;
        public string Letra { get; set; } = string.Empty;
    }
}
