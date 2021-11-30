using System;
using System.Collections.Generic;

namespace PizzariaSemBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza(TipoMassa.Fina,
                                     Tamanho.Grande, 
                                     TipoBorda.Normal, 
                                     new List<string> { "Mussarela", "Molho de tomate", "Oregano" });

            pizza1.PizzaConteudo();
            
            Console.ReadKey();
        }
    }
}
