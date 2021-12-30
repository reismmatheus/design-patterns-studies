using System;

namespace Flyweight2
{
    //ConcreteFlyweight
    public class Circulo : IForma
    {
        //estado extrínseco
        public string Cor { get; set; }
        //estado intrínseco (cache)
        private int x = 10;
        private int y = 20;
        private int raio = 30;
        public void SetCor(string Cor)
        {
            this.Cor = Cor;
        }
        public void Desenhar()
        {
            Console.WriteLine($"Circulo: Desenhar() [Cor:{Cor} x:{x},y:{y}, raio:{raio}]");
        }
    }
}
