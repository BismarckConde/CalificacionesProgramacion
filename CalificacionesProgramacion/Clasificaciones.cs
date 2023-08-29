using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesProgramacion
{
    public class Clasificaciones
    {
        public string nombre { get; set; }
        int[] notas = new int[3];
        int i = 0;


        static int[] calificaciones()
        {
            int[] notas = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" INGRESE LA NOTA (i+1):");
                notas[i] = (int)Convert.ToDouble(Console.ReadLine());
            }
             return notas;

        }
        static double promedio(double[]notas)
        {
            double suma = 0;
        }


    }
}
