﻿namespace Examen.ApplicationCore.Domain
{
    public class Laboratoire
    {
        public string Intitule { get; set; }
        public int LaboratoireId { get; set; }
        public string Localisation { get; set; }

        // many infirmers 
        public ICollection<Infirmier> Infirmiers { get; set; }
    }
}
