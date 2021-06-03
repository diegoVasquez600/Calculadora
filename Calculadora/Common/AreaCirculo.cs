using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Common
{
    public class AreaCirculo
    {
        public AreaCirculo()
        {
            Calcular();
        }

        public static void Calcular()
        {
            //Variables Auxiliares
            double area = 0, radio = 0;
            Console.WriteLine("Encontrar el Area de un Circulo.\n");

            Console.Write("Ingrese el radio del circulo: ");

            radio = int.Parse(Console.ReadLine());

            //Realiza la operacion
            area = radio * radio * 3.1415;
            Console.WriteLine($"El Area del Circulo es {area}\n");
        }
    }
}
