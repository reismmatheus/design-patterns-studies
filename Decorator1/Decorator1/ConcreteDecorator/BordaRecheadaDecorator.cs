using Decorator1.Component;
using Decorator1.Decorator;

namespace Decorator1.ConcreteDecorator
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza)
            : base(pizza)
        { }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\n com borda recheada";
            return pizza;
        }
        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 3.00M;
            return preco;
        }
    }
}
