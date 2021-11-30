using System;
using System.Collections.Generic;

namespace PizzariaSemBuilder
{
    public class Pizza
    {
        private readonly TipoMassa tipoMassa;
        private readonly Tamanho tamanho;
        private readonly TipoBorda tipoBorda;
        private readonly List<string> ingredientes;

        public Pizza(TipoMassa tipoMassa, Tamanho tamanho, 
            TipoBorda tipoBorda, List<string> ingredientes)
        {
            this.tipoMassa = tipoMassa;
            this.tamanho = tamanho;
            this.tipoBorda = tipoBorda;
            this.ingredientes = ingredientes;
        }

        public void PizzaConteudo()
        {
            Console.WriteLine("Pizza com massa : {0}", tipoMassa);
            Console.WriteLine($"Tamanho : {tamanho}");
            Console.WriteLine($"Tipo Borda : {tipoBorda}");
            Console.WriteLine("Ingredientes:");
            foreach (var item in ingredientes)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
