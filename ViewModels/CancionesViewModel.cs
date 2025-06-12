using System.Collections.ObjectModel;
using HipHopMusic.Models;

namespace HipHopMusic.ViewModels
{
    public class CancionesViewModel
    {
        public ObservableCollection<Cancion> Canciones { get; set; }

        // Constructor por defecto requerido por XAML
        public CancionesViewModel()
        {
            Canciones = new ObservableCollection<Cancion>();
        }

        // Constructor adicional si lo necesitas con parámetros
        public CancionesViewModel(string artistaNombre)
        {
            Canciones = new ObservableCollection<Cancion>();

            if (artistaNombre == "Eminem")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Lose Yourself",
                    Imagen = "eminem_dos.jpg",
                    Anio = "2002",
                    Duracion = "5:26",
                    Letra = "Look, if you had one shot, or one opportunity..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Stan",
                    Imagen = "eminem_tres.jpg",
                    Anio = "2000",
                    Duracion = "6:44",
                    Letra = "My tea's gone cold, I'm wondering why I got out of bed at all..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Mockingbird",
                    Imagen = "eminem_cuatro.jpg",
                    Anio = "2004",
                    Duracion = "4:11",
                    Letra = "Yeah... I know sometimes things may not always make sense to you right now..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Without Me",
                    Imagen = "eminem_cinco.jpg",
                    Anio = "2002",
                    Duracion = "4:50",
                    Letra = "Guess who's back, back again..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "The Real Slim Shady",
                    Imagen = "eminem_seis.jpg",
                    Anio = "2000",
                    Duracion = "4:44",
                    Letra = "May I have your attention please? May I have your attention please?..."
                });
            }
            else if (artistaNombre == "Tupac")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Changes",
                    Imagen = "tupac_dos.jpg",
                    Anio = "1998",
                    Duracion = "4:30",
                    Letra = "Come on, come on... I see no changes, wake up in the morning and I ask myself..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "California Love",
                    Imagen = "tupac_tres.jpg",
                    Anio = "1995",
                    Duracion = "4:45",
                    Letra = "California love! California... knows how to party..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Hail Mary",
                    Imagen = "tupac_cuatro.jpg",
                    Anio = "1997",
                    Duracion = "5:12",
                    Letra = "Makaveli in this... Killuminati, all through your body..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Dear Mama",
                    Imagen = "tupac_cinco.jpg",
                    Anio = "1995",
                    Duracion = "4:40",
                    Letra = "You are appreciated... When I was young me and my mama had beef..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Hit 'Em Up",
                    Imagen = "tupac_seis.jpg",
                    Anio = "1996",
                    Duracion = "5:11",
                    Letra = "First off, f*** your b**** and the clique you claim..."
                });
            }

            else if (artistaNombre == "Wu-Tang Clan")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "C.R.E.A.M.",
                    Imagen = "wutang_dos.jpg",
                    Anio = "1993",
                    Duracion = "4:12",
                    Letra = "Cash Rules Everything Around Me, C.R.E.A.M. get the money..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Protect Ya Neck",
                    Imagen = "wutang_tres.jpg",
                    Anio = "1993",
                    Duracion = "4:50",
                    Letra = "So what's up man? Cooling man. Chilling chilling? Yo you know I had to call..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Triumph",
                    Imagen = "wutang_cuatro.jpg",
                    Anio = "1997",
                    Duracion = "5:38",
                    Letra = "I bomb atomically, Socrates' philosophies and hypotheses..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Gravel Pit",
                    Imagen = "wutang_cinco.jpg",
                    Anio = "2000",
                    Duracion = "4:05",
                    Letra = "Back, back and forth and forth, let me see you go back and forth..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Reunited",
                    Imagen = "wutang_seis.jpg",
                    Anio = "1997",
                    Duracion = "5:27",
                    Letra = "Reunited, double LP world excited, struck a match to the underground..."
                });
            }
            else if (artistaNombre == "Nas")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "N.Y. State of Mind",
                    Imagen = "nas_dos.jpg",
                    Anio = "1994",
                    Duracion = "4:54",
                    Letra = "Rappers I monkey flip 'em with the funky rhythm I be kickin'..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "The World Is Yours",
                    Imagen = "nas_tres.jpg",
                    Anio = "1994",
                    Duracion = "4:50",
                    Letra = "I sip the Dom P, watching Gandhi 'til I'm charged..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "If I Ruled the World (Imagine That)",
                    Imagen = "nas_cuatro.jpg",
                    Anio = "1996",
                    Duracion = "4:42",
                    Letra = "If I ruled the world, imagine that, I'd free all my sons..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Hate Me Now",
                    Imagen = "nas_cinco.jpg",
                    Anio = "1999",
                    Duracion = "4:44",
                    Letra = "Escobar season has returned... You can hate me now..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "One Mic",
                    Imagen = "nas_seis.jpg",
                    Anio = "2002",
                    Duracion = "4:28",
                    Letra = "All I need is one mic, one beat, one stage..."
                });
            }

            else if (artistaNombre == "Dr. Dre")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Still D.R.E.",
                    Imagen = "drdre_dos.jpg",
                    Anio = "1999",
                    Duracion = "4:30",
                    Letra = "Still... still doing that s***, huh Dre?"
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "The Next Episode",
                    Imagen = "drdre_tres.jpg",
                    Anio = "2000",
                    Duracion = "2:41",
                    Letra = "Da da da da da, it's the motherf***in' D-O-double-G..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Nuthin' But a 'G' Thang",
                    Imagen = "drdre_cuatro.jpg",
                    Anio = "1992",
                    Duracion = "3:58",
                    Letra = "One, two, three and to the fo'... Snoop Doggy Dogg and Dr. Dre is at the do'..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Forgot About Dre",
                    Imagen = "drdre_cinco.jpg",
                    Anio = "2000",
                    Duracion = "3:42",
                    Letra = "Y'all know me, still the same O.G. but I been low-key..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Let Me Ride",
                    Imagen = "drdre_seis.jpg",
                    Anio = "1993",
                    Duracion = "4:21",
                    Letra = "Creepin' down the back street on Deez... I got my Glock cocked..."
                });
            }
            else if (artistaNombre == "Bone Thugs")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Tha Crossroads",
                    Imagen = "bonethugs_dos.jpg",
                    Anio = "1996",
                    Duracion = "3:43",
                    Letra = "And we pray, and we pray, and we pray, and we pray..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "1st of tha Month",
                    Imagen = "bonethugs_tres.jpg",
                    Anio = "1995",
                    Duracion = "5:15",
                    Letra = "Wake up, wake up, wake up, it's the first of the month..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Foe tha Love of $",
                    Imagen = "bonethugs_cuatro.jpg",
                    Anio = "1995",
                    Duracion = "4:30",
                    Letra = "Well, it's Bone and Biggie, Biggie... it's Bone and Biggie, Biggie..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Ecstasy",
                    Imagen = "bonethugs_cinco.jpg",
                    Anio = "2000",
                    Duracion = "4:00",
                    Letra = "Ecstasy, ecstasy, is all you need..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Resurrection (Paper, Paper)",
                    Imagen = "bonethugs_seis.jpg",
                    Anio = "2000",
                    Duracion = "4:05",
                    Letra = "Gimme paper, gimme paper, gimme that which I desire..."
                });
            }
            else if (artistaNombre == "Psycho Realm")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Psycho City Blocks",
                    Imagen = "psycho_dos.jpg",
                    Anio = "1997",
                    Duracion = "4:26",
                    Letra = "Welcome to the Psycho Realm... Where the little locos roam..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Stone Garden",
                    Imagen = "psycho_tres.jpg",
                    Anio = "1997",
                    Duracion = "5:02",
                    Letra = "In the stone garden, we keep all the illest... underground dwellers..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Showdown",
                    Imagen = "psycho_cuatro.jpg",
                    Anio = "1997",
                    Duracion = "4:35",
                    Letra = "It's the showdown, so you better bow down..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "The Big Payback",
                    Imagen = "psycho_cinco.jpg",
                    Anio = "2000",
                    Duracion = "4:28",
                    Letra = "This is the big payback... feel the wrath of the Psycho attack..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Premonitions",
                    Imagen = "psycho_seis.jpg",
                    Anio = "1997",
                    Duracion = "4:13",
                    Letra = "Visions of the future so cold, got me locked and controlled..."
                });
            }
            else if (artistaNombre == "N.W.A")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Straight Outta Compton",
                    Imagen = "nwa_dos.jpg",
                    Anio = "1988",
                    Duracion = "4:18",
                    Letra = "Straight outta Compton, crazy motherf***er named Ice Cube..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "F*** tha Police",
                    Imagen = "nwa_tres.jpg",
                    Anio = "1988",
                    Duracion = "5:45",
                    Letra = "Right about now, N.W.A court is in full effect..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Express Yourself",
                    Imagen = "nwa_cuatro.jpg",
                    Anio = "1989",
                    Duracion = "4:24",
                    Letra = "Express yourself! You don't ever need help from nobody else..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Gangsta Gangsta",
                    Imagen = "nwa_cinco.jpg",
                    Anio = "1988",
                    Duracion = "5:36",
                    Letra = "Here's a little somethin' 'bout a n**** like me..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Appetite for Destruction",
                    Imagen = "nwa_seis.jpg",
                    Anio = "1991",
                    Duracion = "5:35",
                    Letra = "I'm a street fighter, some say a riot starter..."
                });
            }
            else if (artistaNombre == "Cypress Hill")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Insane in the Brain",
                    Imagen = "cypress_dos.jpg",
                    Anio = "1993",
                    Duracion = "3:29",
                    Letra = "Insane in the membrane, insane in the brain!"
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Tequila Sunrise",
                    Imagen = "cypress_tres.jpg",
                    Anio = "1998",
                    Duracion = "4:44",
                    Letra = "I got my mind on the scope and the money on my brain..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Hits from the Bong",
                    Imagen = "cypress_cuatro.jpg",
                    Anio = "1993",
                    Duracion = "2:41",
                    Letra = "Hits from the bong... pick it, pack it, fire it up, come along..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "I Ain't Goin' Out Like That",
                    Imagen = "cypress_cinco.jpg",
                    Anio = "1993",
                    Duracion = "4:27",
                    Letra = "I ain't goin' out like that! I ain't goin' out like that!"
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Latin Lingo",
                    Imagen = "cypress_seis.jpg",
                    Anio = "1991",
                    Duracion = "3:58",
                    Letra = "Latin lingo, baby! Chicano, and I'm proud to be Latino..."
                });
            }
            else if (artistaNombre == "Mobb Deep")
            {
                Canciones.Add(new Cancion
                {
                    Nombre = "Shook Ones Pt. II",
                    Imagen = "mobbdeep_dos.jpg",
                    Anio = "1995",
                    Duracion = "4:25",
                    Letra = "I got you stuck off the realness, we be the infamous..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Survival of the Fittest",
                    Imagen = "mobbdeep_tres.jpg",
                    Anio = "1995",
                    Duracion = "3:43",
                    Letra = "There's a war going on outside no man is safe from..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Quiet Storm",
                    Imagen = "mobbdeep_cuatro.jpg",
                    Anio = "1999",
                    Duracion = "4:00",
                    Letra = "Ayo, it's the real... yo, I'm talking about the realness..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Hell On Earth (Front Lines)",
                    Imagen = "mobbdeep_cinco.jpg",
                    Anio = "1996",
                    Duracion = "4:15",
                    Letra = "I got you, stuck off the realness, we be the infamous..."
                });

                Canciones.Add(new Cancion
                {
                    Nombre = "Temperature's Rising",
                    Imagen = "mobbdeep_seis.jpg",
                    Anio = "1995",
                    Duracion = "4:38",
                    Letra = "Temperature's risin', and I'm about to lose control..."
                });
            }


        }
    }
}
