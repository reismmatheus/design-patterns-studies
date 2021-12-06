using Adapter1.Adaptee;
using Adapter1.Domain;

namespace Adapter1.Adapter
{
    public class CalculadoraAdapter
    {
        public double GetArea(Triangulo triangulo)
        {
            Calculadora calcula = new Calculadora();
            Retangulo retangulo = new Retangulo();

            //Area do Triangulo=0.5*base*altura
            retangulo.alturaRetangulo = triangulo.alturaTriangulo;
            retangulo.baseRetangulo = 0.5 * triangulo.baseTriangulo;
            return calcula.GetArea(retangulo);
        }
    }
}
