using Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Common
{
    public class Suma
    {
        public Suma()
        {
            Sumar();
        }

        public static void Sumar()
        {
            CommonModel val = new();
            Console.WriteLine($"Sumar dos Valores \n" +
                $"Ingrese el Valor 1:\n");
            val.x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el Valor 2:\n");
            val.y = int.Parse(Console.ReadLine());
            Console.WriteLine($"El Resultado de {val.x} + {val.y} = {val.x + val.y}\n");

        }
    }
}
