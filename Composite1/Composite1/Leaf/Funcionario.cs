using Composite1.Component;
using System;

namespace Composite1.Leaf
{
    //Representa o Leaf
    public class Funcionario : HoraTrabalhada
    {
        public int Id { get; set; }
        public int Horas { get; set; }
        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"O Funcionário {Id}-{Nome} registrou {Horas} trabalhadas");
            return Horas;
        }
    }
}
