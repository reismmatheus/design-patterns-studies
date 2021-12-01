using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shallow Copy
            var soldierShallow = new ShallowCopy.ConcretePrototype.Soldier();
            soldierShallow.Name = "Soldier 1";
            soldierShallow.Weapon = "Weapon 1";
            soldierShallow.Accessory = new ShallowCopy.ConcretePrototype.Accessory { Name = "Accesory 1" };

            var soldierShallowoCopy = (ShallowCopy.ConcretePrototype.Soldier)soldierShallow.Clone();
            soldierShallowoCopy.Name = "Soldier 2";
            soldierShallowoCopy.Weapon = "Weapon 2";
            soldierShallowoCopy.Accessory.Name = "Accessory 2";

            //Deep Copy
            var soldierDeep = new DeepCopy.ConcretePrototype.Soldier();
            soldierDeep.Name = "Soldier 1";
            soldierDeep.Weapon = "Weapon 1";
            soldierDeep.Accessory = new DeepCopy.ConcretePrototype.Accessory { Name = "Accesory 1" };

            var soldierDeepCopy = (DeepCopy.ConcretePrototype.Soldier)soldierDeep.Clone();
            soldierDeepCopy.Name = "Soldier 2";
            soldierDeepCopy.Weapon = "Weapon 2";
            soldierDeepCopy.Accessory.Name = "Accessory 2";

            Console.WriteLine("Shallow Copy");
            Console.WriteLine("Original");
            Console.WriteLine($"Name: {soldierShallow.Name} - Weapon: {soldierShallow.Weapon} - Accessory: {soldierShallow.Accessory.Name}");
            Console.WriteLine("Copy");
            Console.WriteLine($"Name: {soldierShallowoCopy.Name} - Weapon: {soldierShallowoCopy.Weapon} - Accessory: {soldierShallowoCopy.Accessory.Name}");

            Console.WriteLine("Deep Copy");
            Console.WriteLine("Original");
            Console.WriteLine($"Name: {soldierDeep.Name} - Weapon: {soldierDeep.Weapon} - Accessory: {soldierDeep.Accessory.Name}");
            Console.WriteLine("Copy");
            Console.WriteLine($"Name: {soldierDeepCopy.Name} - Weapon: {soldierDeepCopy.Weapon} - Accessory: {soldierDeepCopy.Accessory.Name}");

            Console.ReadLine();
        }
    }
}
