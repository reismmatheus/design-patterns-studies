using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.DeepCopy.ConcretePrototype
{
    public class Soldier
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public Accessory Accessory { get; set; }
        public Soldier() { }
        public Soldier(Soldier soldier)
        {
            Name = soldier.Name;
            Weapon = soldier.Weapon;
            Accessory = soldier.Accessory;
        }

        public object Clone()
        {
            var soldier = (Soldier)MemberwiseClone();
            soldier.Accessory = (Accessory)Accessory.Clone();
            return soldier;
        }
    }
}
