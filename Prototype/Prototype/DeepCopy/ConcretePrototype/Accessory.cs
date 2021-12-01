using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.DeepCopy.ConcretePrototype
{
    public class Accessory
    {
        public string Name { get; set; }

        public object Clone()
        {
            return (Accessory)MemberwiseClone();
        }
    }
}
