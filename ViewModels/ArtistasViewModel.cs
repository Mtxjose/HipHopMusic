using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using HipHopMusic.Models;

namespace HipHopMusic.ViewModels
{
    public class ArtistasViewModel
    {
        public ObservableCollection<Artista> Artistas { get; set; }

        public ArtistasViewModel()
        {
            Artistas = new ObservableCollection<Artista>
            {
                new Artista { Nombre = "Eminem", Ranking = "1", UltimoAlbum = "Curtain Call 2", Imagen = "eminem.jpg" },
                new Artista { Nombre = "Wu-Tang Clan", Ranking = "2", UltimoAlbum = "Once Upon a Time in Shaolin", Imagen = "wutang_clan.jpg" },
                new Artista { Nombre = "Cypress Hill", Ranking = "3", UltimoAlbum = "Back in Black", Imagen = "cypresshill.jpg" },
                new Artista { Nombre = "Tupac", Ranking = "4", UltimoAlbum = "Pac’s Life", Imagen = "tupac.jpg" },
                new Artista { Nombre = "Psycho Realm", Ranking = "5", UltimoAlbum = "A War Story Book II", Imagen = "psychorealm.jpg" },
                new Artista { Nombre = "Nas", Ranking = "6", UltimoAlbum = "King’s Disease III", Imagen = "nas.jpg" },
                new Artista { Nombre = "Mobb Deep", Ranking = "7", UltimoAlbum = "The Infamous Mobb Deep", Imagen = "mobb_deep.jpg" },
                new Artista { Nombre = "Dr. Dre", Ranking = "8", UltimoAlbum = "Compton", Imagen = "dr_dre.jpg" },
                new Artista { Nombre = "Bone Thugs", Ranking = "9", UltimoAlbum = "New Waves", Imagen = "bonethugs.jpg" },
                new Artista { Nombre = "N.W.A", Ranking = "10", UltimoAlbum = "Straight Outta Compton", Imagen = "nwa.jpg" },
            };
        }
    }
}
