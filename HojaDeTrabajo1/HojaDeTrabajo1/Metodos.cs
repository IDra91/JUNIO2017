using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaDeTrabajo1
{
    class Metodos
    {

        public Double hipotenusa(int lado1, int lado2)
        {
            double hip;
            hip = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(lado2, 2));
            Console.WriteLine("El resultado es: " + hip);
            return hip;
        }

        public String reves(String cadena1, String cadena2)
        {
            String cadena;
            cadena = cadena1 + cadena2;
            char[] arreglo = cadena.ToCharArray();
            Array.Reverse(arreglo);
            Console.WriteLine("El resultado es:" + arreglo);
            return new string(arreglo);

        }
    }
}
