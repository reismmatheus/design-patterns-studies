using Builder1.Builder;
using Builder1.Product;
using System.Collections.Generic;

namespace Builder1.ConcreteBuilder
{
    public sealed class PizzaCalabreza : PizzaBuilder
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Normal;
            pizza.Tamanho = Tamanho.Grande;
        }
        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Calabreza em fatias", 
                "Molho de tomate" }; 
        }
    }
}
