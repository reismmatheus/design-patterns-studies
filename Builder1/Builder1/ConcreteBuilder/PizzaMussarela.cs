using Builder1.Builder;
using Builder1.Product;
using System.Collections.Generic;

namespace Builder1.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuilder
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Normal;
            pizza.TipoBorda = TipoBorda.Recheada;
            pizza.Tamanho = Tamanho.Grande;
        }
        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Mussarela", 
                "Molho de tomate", "Orégano" };
        }
    }
}
