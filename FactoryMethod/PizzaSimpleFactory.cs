﻿using System;

namespace FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;
            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException($"A pizzaria {local} não foi criada");
            }
            return pizzaria;
        }
    }
}
