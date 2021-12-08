﻿using Composite1.Component;
using System;
using System.Collections.Generic;

namespace Composite1.Composite
{
    //representa o Composite
    public class Organizacao : HoraTrabalhada
    {
        protected List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>();
        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }
        public override void Remove(HoraTrabalhada component)
        {
            departamentos.Remove(component);
        }
        /// funcionalidade comum
        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;
            foreach (var departamento in departamentos)
            {
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
            }
            Console.WriteLine($"{Nome} registrou um total de [{horasTrabalhadasDepartamento}] horas\n");
            return horasTrabalhadasDepartamento;
        }
    }
}
