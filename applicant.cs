using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

/* 3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
 * El programa recibirá como entrada el número total de preguntas y las respuestas correctas, y devolverá 
 * un nivel según el porcentaje de aciertos.

Nivel máximo: Porcentaje>=90%.

Nivel medio: Porcentaje>=75% y <90%.

Nivel regular: Porcentaje>=50% y <75%.

Fuera de nivel: Porcentaje<50%. */

namespace Itla3raParteModulo1
{
    internal class Applicant
    {
        public static void Calculating_Percentage(int A, int B)
        {
            //int Total_ofQuetions = A;
            //int Correct_Quetions = B; 

            if (A == 0)
            {
                Console.WriteLine("El número total de preguntas no puede ser cero. ");
                return; 
            }
            // Calcula el porcentaje de los aciertos 
            double percentage = ((double)A / B) * 100;
            int roundedPercentage = (int)Math.Floor(percentage / 10) * 10;

            string nivel = roundedPercentage switch
            {
                >= 90 => "Nivel máximo",
                >= 75 => "Nivel medio",
                >= 50 => "Nivel regular",
                _ => "Fuera de nivel"
            };

            // Mostrar el resultado
            Console.WriteLine($"El porcentaje de aciertos es: {percentage}%");
            Console.WriteLine($"El nivel del postulante es: {nivel}");
         
        }
    }
}
