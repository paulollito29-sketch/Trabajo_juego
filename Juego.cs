using System.Collections.Generic;

namespace TareaAcademica5
{
    public class Juego
    {
        public string IdJuego { get; set; }
        public string Titulo { get; set; }
        public List<Participante> ListaParticipantes { get; set; } = new List<Participante>();
    }
}