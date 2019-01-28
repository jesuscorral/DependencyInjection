namespace DependencyInjectionSimpleExample
{
    public class Soldado
    {
        public IArma arma;

        public Soldado(IArma arma)
        {
            this.arma = arma;
        }

        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }
}
