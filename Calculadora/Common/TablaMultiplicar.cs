using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Common
{
    public class TablaMultiplicar
    {
        public TablaMultiplicar()
        {
            Tabla();
        }

        public static void Tabla()
        {
            //Variables
            int cont = 0, numero, result;

            //Explicacion del Ejercicio
            Console.Write("\n\tTabla de Multiplicar con ciclo for\n");

            //Imprimiendo mensaje, el cual pide un dato
            Console.Write("Ingrese el numero al que le quiere calcular la tabla: ");

            //Ingresando El Valor
            numero = int.Parse(Console.ReadLine());

            //Ciclo For (Tabla de Multiplicar)
            Console.Write("\nTABLA DE MULTIPLICAR EL {0} \n\n", numero);
            for (cont = 1; cont <= 10; cont++)
            {
                result = cont * numero;
                Console.WriteLine(cont + " X " + numero + " = " + result);
            }

            //Detener el programa, esperando que se presione una tecla
            Console.Write("\n\n\tPresione <<ENTER>> para continuar . . .");
            Console.ReadKey();
        }
    }
}
