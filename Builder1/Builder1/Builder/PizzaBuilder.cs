using Builder1.Product;

namespace Builder1.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public void CriaPizza()
        {
            pizza = new Pizza();
        }
        public Pizza GetPizza()
        {
            return pizza;
        }
        public abstract void PreparaMassa();
        public abstract void IncluiIngredientes();
    }
}
