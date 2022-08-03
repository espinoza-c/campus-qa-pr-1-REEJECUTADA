using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewReejecucion
{
    public class Persona
    {
        public Persona(string name, string email, DateTime birthday)
        {
            Name = name;
            Email = email;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }


        public static List<string> ConvierteSoloEmails(List<Persona> listaPersonas)
        {
            var listaEmails = from email in listaPersonas
                              select email.Email;
            return listaEmails.ToList();
        }

        public static Persona FiltraPorCumpleañosYRetornaPrimero(List<Persona> listaPersonas, DateTime fechaFiltro)
        {
            var personasFiltradas = from persona in listaPersonas
                                    where persona.Birthday > fechaFiltro
                                    select persona;
            Console.WriteLine("La persona filtrada es" + personasFiltradas.First().Name);
            return personasFiltradas.First();
        }

    }
}
