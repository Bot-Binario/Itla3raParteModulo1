/* 3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
 * El programa recibirá como entrada el número total de preguntas y las respuestas correctas, y devolverá 
 * un nivel según el porcentaje de aciertos.

Nivel máximo: Porcentaje>=90%.

Nivel medio: Porcentaje>=75% y <90%.

Nivel regular: Porcentaje>=50% y <75%.

Fuera de nivel: Porcentaje<50%. */

using Itla3raParteModulo1;
using System;

namespace Level_ofApplicant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el número total de preguntas
            Console.WriteLine("Ingrese el número total de preguntas:");
            int totalQuestions = int.Parse(Console.ReadLine());

            // Solicitar al usuario que ingrese el número de respuestas correctas
            Console.WriteLine("Ingrese el número de respuestas correctas:");
            int correctAnswers = int.Parse(Console.ReadLine());

            // Llamar al método para calcular el porcentaje y el nivel
            Applicant.Calculating_Percentage(totalQuestions, correctAnswers);
        }
    }
}

