using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopMusic.Models
{
    public class Artista
    {
        public string Nombre { get; set; } = string.Empty;
        public string Imagen { get; set; } = string.Empty;
        public string UltimoAlbum { get; set; } = string.Empty;
        public string Ranking { get; set; } = string.Empty;  // ← CAMBIADO DE int A string
    }
}
