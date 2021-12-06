using Adapter1.Domain;

namespace Adapter1.Adaptee
{
    public class Calculadora
    {
        public double GetArea(Retangulo retangulo)
        {
            return retangulo.baseRetangulo * 
                  retangulo.alturaRetangulo;
        }
    }
}
