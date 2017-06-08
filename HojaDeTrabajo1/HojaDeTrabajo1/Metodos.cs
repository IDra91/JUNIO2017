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

        public String vocales(string cadena)
        {
            bool a = false;
            bool e = false;
            bool I = false;
            bool o = false;
            bool u = false;
            char caracter;
            int estadoActual = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena[i];
                // Esto lo que hace es que separa la cadena que necesitás en caracteres
                switch (estadoActual)
                {
                    case 0:
                        if ((a = true) && (e = true) && (I = true) && (o = true) && (u = true))
                        {
                            estadoActual = 1;
                        }
                        else
                        {
                            if (caracter == 'a')
                            {
                                estadoActual = 0;
                                a = true;
                            }
                            else if (caracter == 'e')
                            {
                                estadoActual = 0;
                                e = true;
                            }
                            else if (caracter == 'i')
                            {
                                estadoActual = 0;
                                I = true;
                            }
                            else if (caracter == 'o')
                            {
                                estadoActual = 0;
                                o = true;
                            }
                            else if (caracter == 'u')
                            {
                                estadoActual = 0;
                                u = true;
                            }
                            else estadoActual = 0;
                        }

                        break;

                    case 1:
                        return "Cumple";

                }
            }
            return "No cumple";
        }

        public int regla(int n1, int n2, int n3)
        {
            int parcial = 0;
            int final = 0;

            parcial = (n2 / n1);
            final = parcial * n3;
            return final;
        }


    }
}
