//incluido blibliotecas
using System;
using System.Globalization;
//nome 
namespace couse
{
    // criando a classe programa
    public class Program
    {


        //programa principal
        public static void main(string[] args)
        {
            //variaveis double para calculos grandes, e funcoes para facilitar o programa
            double[] medidasX = LerMedidasTriangulo("x");
            double[] medidasY = LerMedidasTriangulo("y");
            //variaveis da area, pegar a mdedida da funcao para fazer o calculo
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            Console.WriteLine("Area de x = " + areaX.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y = " + areaY.ToString(CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area = X");
            }
            else
            {
                Console.WriteLine("maior area = Y");
            }
        }
        // funcao atribuido os valores e array
        public static double[] LerMedidasTriangulo(string nometriangulo)
        {
            // colocando a quantidade de numeros na array
            double[] medidas = new double[3];
            // interface de usuario de atribuicao de valores do triangulo
            Console.WriteLine("Entre com as medidas do triangulo " + nometriangulo + ":");
            //variavel de repeticao aonde irar passar por todos os resultados e colocando os valores na array
            for (int i = 0; i < 3; i++)
            {
                //atribuicao de valores 0 1 2 da array
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //return
            return medidas;
        }
        //funcao de calculo
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            //variavel de atribuicao de variavel 
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];
            //variavel de calculo de perimetro
            double p = (a + b + c) / 2.0;
            //variavel de calculo da area
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}









