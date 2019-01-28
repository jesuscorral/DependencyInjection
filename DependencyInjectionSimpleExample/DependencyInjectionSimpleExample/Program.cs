using System;

namespace DependencyInjectionSimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldadoRevolver = new Soldado(new Revolver());
            Console.WriteLine(soldadoRevolver.Disparar());

            var soldadoEscopeta = new Soldado(new Escopeta());
            Console.WriteLine(soldadoEscopeta.Disparar());

            var soldadoMetralleta = new Soldado(new Metralleta());
            Console.WriteLine(soldadoEscopeta.Disparar());

            Console.ReadLine();
        }
    }
}
