using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ShallowCopy.ConcretePrototype
{
    public class Soldier : ICloneable
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
            return new Soldier(this);
        }
    }
}
