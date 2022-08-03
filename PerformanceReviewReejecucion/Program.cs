using System;
using System.Collections.Generic;


namespace PerformanceReviewReejecucion
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona("Carlos", "carlos@prueba.com", new DateTime(1997,03,18)),
                new Persona("Antonio", "antonio@prueba.com", new DateTime(2000,03,18)),
                new Persona("Juan","juan@prueba.com", new DateTime(2002,03,18)),
                new Persona("Arturo","arturo@prueba.com", new DateTime(2005,03,18)),
                new Persona("Nombre", "nombre@prueba.com", new DateTime(1985,03,18)),
                new Persona("Andrea", "andrea@prueba.com", new DateTime(1950,03,18))
            };

            var soloEmails = Persona.ConvierteSoloEmails(personas);
            var retornaPrimero = Persona.FiltraPorCumpleañosYRetornaPrimero(personas, new DateTime(2002,01,01));

            for (int i = 0; i < soloEmails.Count; i++)
            {
                Console.WriteLine(soloEmails[i]);
            }

            Console.WriteLine(retornaPrimero.Name);
            

        }
        
    }
}
