using System;
using System.Collections.Generic;
using Xunit;

namespace PerformanceReviewReejecucion
{

        public class PersonaShould
        {
            [Fact]
            public void ConvierteSoloEmails_DatosValidos()
            {
                //Arrange
                List<Persona> personas = new List<Persona>()
            {
                new Persona("Carlos", "carlos@prueba.com", new DateTime(1997,03,18)),
                new Persona("Antonio", "antonio@prueba.com", new DateTime(2000,03,18)),
                new Persona("Juan","juan@prueba.com", new DateTime(2002,03,18)),
                new Persona("Arturo","arturo@prueba.com", new DateTime(2005,03,18)),
                new Persona("Nombre", "nombre@prueba.com", new DateTime(1985,03,18)),
                new Persona("Andrea", "andrea@prueba.com", new DateTime(1950,03,18))
            };

                List<string> expectedListaemails;
                List<string> actualListaemails;

                expectedListaemails = new List<string>()
            {
                "carlos@prueba.com",
                "antonio@prueba.com",
                "juan@prueba.com",
                "arturo@prueba.com",
                "nombre@prueba.com",
                "andrea@prueba.com"
            };


                //Act
                actualListaemails = Persona.ConvierteSoloEmails(personas);


                //Assert
                Assert.Equal(expectedListaemails, actualListaemails);
            }

            [Fact]
            public void retornaPrimerElementoDeListaFiltrada()
            {
                //Arrange
                List<Persona> personas = new List<Persona>()
            {
                new Persona("Carlos", "carlos@prueba.com", new DateTime(1997,03,18)),
                new Persona("Antonio", "antonio@prueba.com", new DateTime(2000,03,18)),
                new Persona("Juan","juan@prueba.com", new DateTime(2002,03,18)),
                new Persona("Arturo","arturo@prueba.com", new DateTime(2005,03,18)),
                new Persona("Nombre", "nombre@prueba.com", new DateTime(1985,03,18)),
                new Persona("Andrea", "andrea@prueba.com", new DateTime(1950,03,18))
            };

                var expectedRetornado = "Juan";
                DateTime fechaFiltro = new DateTime(2002, 01, 01);

                //Act
                var actualRetornado = Persona.FiltraPorCumpleañosYRetornaPrimero(personas, fechaFiltro);

                //Assert
                Assert.Equal(expectedRetornado, actualRetornado.Name);

            }
        }
    }

