using System;
using System.Globalization;

namespace couse
{
    public class Program
    {



        public static void main(string[] args)
        {
            double[] medidasX = LerMedidasTriangulo("x");
            double[] medidasY = LerMedidasTriangulo("y");

            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            Console.WriteLine("Area de x = " + areaX.ToString("f4",CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y = " + areaY.ToString("f4",CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area = X");
            }
            else
            {
                Console.WriteLine("maior area = Y");
            }
        }

        public static double[] LerMedidasTriangulo(string nometriangulo)
        {
            double[] medidas = new double[3];

            Console.WriteLine("Entre com as medidas do triangulo " + nometriangulo + ":");
            for(int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            return medidas;
        }

        public static double CalcularAreaTriangulo(double[] medidas)
        {
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}        









