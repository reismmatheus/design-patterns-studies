using System;

namespace PizzariaSemFactory
{
    public class PizzaMussarela
    {
        public string Nome { get; set; }
        public PizzaMussarela()
        {
            Nome = "Pizza de Mussarela";
        }
        public void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}\n");
        }
    }
}
