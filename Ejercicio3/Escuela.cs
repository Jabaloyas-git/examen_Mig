using System;

namespace Ejercicio3_Refactorizacion
{
    /// <summary>
    /// Clase Escuela — versión REFACTORIZADA (con los 10 errores corregidos).
    /// La clase original con errores se muestra en el formulario para comparación.
    /// </summary>
    public class Escuela
    {
        // FIX 9: constante nombrada en lugar de magic string inline
        private const string NORMATIVA_EVALUACION =
            "Según el artículo 34 de la normativa vigente del centro escolar, " +
            "referida a la evaluación continua de los alumnos de primer curso.";

        private const double NOTA_MINIMA_APROBADO = 5.0;

        public void EvaluarAlumno()
        {
            string nombreAlumno = "Juan";        // FIX 1: camelCase, no MAYUSCULAS
            string materia = "Matemáticas";       // FIX 2: sin new String(...)
            int notaBase = 8;                     // FIX 3: nombre descriptivo, no 'x'
            double resultado = notaBase + 5.0/2; // FIX 4: 5.0/2 = 2.5, resultado = 10.5
                                                  // FIX 5: eliminado 'x = 18' (dead code)

            if (resultado < NOTA_MINIMA_APROBADO)
            {
                ImprimirBoletin("Suspenso", 0, "Repasar", true, 0, "Tutoría");
            }

            bool esAlumnoMenor = true;            // FIX 6: 'bool' (C#), no 'boolean' (Java)

            if (esAlumnoMenor)                    // FIX 7+10: un solo bloque, sin '== true'
            {
                Console.WriteLine("Enviar correo a los padres informando de la situación.");
            }

            // FIX 8: bucle con formato correcto, llaves en líneas propias
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(NORMATIVA_EVALUACION); // FIX 9: uso de la constante

            ImprimirBoletin("Aprobado", 10, "Bien", false, 0, "Casa");
        }

        public void ImprimirBoletin(string estado, int codigo, string observacion,
                                     bool requiereFirma, int copias, string destino)
        {
            Console.WriteLine(string.Format("[{0}] Estado: {1} | Obs: {2}",
                                            codigo, estado, observacion));
        }
    }
}
