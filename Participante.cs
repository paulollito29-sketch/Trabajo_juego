using System.Collections.Generic;

namespace TareaAcademica5
{
    public class Participante
    {
        public string Documento { get; set; }
        public string Nickname { get; set; }
        public List<Juego> JuegosInscritos { get; set; } = new List<Juego>();
    }
}