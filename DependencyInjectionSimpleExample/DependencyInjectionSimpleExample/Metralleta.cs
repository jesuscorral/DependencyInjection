using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSimpleExample
{
    public class Metralleta : IArma
    {
        public string Disparar()
        {
            return "Disparo de Metralleta";
        }
    }
}
