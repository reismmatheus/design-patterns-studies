using System.Collections;

namespace AbstractFactoryDemo.Domain.Products
{
    //ProductA2
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", Enums.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}
