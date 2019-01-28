using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSimpleExample
{
    public class Revolver : IArma
    {
        public string Disparar()
        {
            return "Disparo de revolver";
        }
    }
}
