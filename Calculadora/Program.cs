using Calculadora.Common;
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Opciones();
        }

        private static void Opciones()
        {
            int opcion = new();
            Console.WriteLine($"A continuacion selecione alguna de las siguientes opciones\n" +
                $"1) Suma\n" +
                $"2) Resta\n" +
                $"3) Multiplicacion\n" +
                $"4) Division\n" +
                $"5) Area Circulo\n" +
                $"6) Tabla de Multiplicar\n");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                //Llamar Clase de Suma
                Suma.Sumar();
                Opciones();
            }
            else if (opcion == 2)
            {
                //Llamar Clase de Resta
                Resta.Restar();
                Opciones();
            }
            else if (opcion == 3)
            {
                //Llamar Calse de Multiplicar
                Multiplicacion.Multiplicar();
                Opciones();
            }
            else if (opcion == 4)
            {
                //Llamar Clase de Division
                Division.Dividir();
                Opciones();
            }
            else if (opcion == 5)
            {
                //Llamar Calse de Area Circulo
                AreaCirculo.Calcular();
                Opciones();
            }
            else if (opcion == 6)
            {
                //Llamar Clase de Tabla de Multiplicar
                TablaMultiplicar.Tabla();
                Opciones();
            }
        }
    }
}
