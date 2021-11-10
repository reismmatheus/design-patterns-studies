using AbstractFactoryDemo.Domain.Enums;
using AbstractFactoryDemo.Domain.Products;
using System;
namespace AbstractFactoryDemo.Factory.AbstractFactory
{
    //AbstractFactory
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBase CriaMassa(TipoMassa tipoMassa);
        public static MassasAbstractFactory CriaFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                {
                    return new PizzaFactory();
                }
                case TipoMassa.Bolo:
                {
                    return new BoloFactory();
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null);
            }
        }
    }
}
