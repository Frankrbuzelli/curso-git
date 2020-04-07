using System;
using System.Globalization;

namespace Aula46_MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
            static void Main(string[] args)
            {
            Console.WriteLine("Entre com o valor do Raio:  ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);

            Console.WriteLine("O valor da circunferencia e: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(raio);

            Console.WriteLine("O volume é: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de Pi é: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Alteracao: Validacao Git");
            }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3.0);
        }
    
    
    
    }
}
