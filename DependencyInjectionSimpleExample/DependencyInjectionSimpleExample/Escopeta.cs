using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSimpleExample
{
    public class Escopeta : IArma
    {
        public string Disparar()
        {
            return "Disparo de Escopeta";
        }
    }
}
