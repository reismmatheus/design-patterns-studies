using Decorator1.Component;

namespace Decorator1.ConcreteComponent
{
    //concretecomponent
    public class Pizza : IPizza
    {
        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }

        public string Opcionais()
        {
            var pizza = "Pizza padrão ou normal";
            return pizza;
        }
    }
}
