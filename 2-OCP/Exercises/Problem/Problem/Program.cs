using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal { Name = "Tigre", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Carnivoro });
            animals.Add(new Animal { Name = "Aguila", Class = AnimalClass.Aves, Order = AnimalOrder.Carnivoro });
            animals.Add(new Animal { Name = "Condor", Class = AnimalClass.Aves, Order = AnimalOrder.Carnivoro });
            animals.Add(new Animal { Name = "Pez globo", Class = AnimalClass.Peces, Order = AnimalOrder.Carnivoro });
            animals.Add(new Animal { Name = "Vaca", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Herbivoro });
            animals.Add(new Animal { Name = "Oveja", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Herbivoro });

            Console.WriteLine("Todos:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Order: {animal.Order}");
            }

            Console.WriteLine("Aves:");
            foreach (var animal in new AnimalFilter().FilterAnimal<Animal>((o)=> o.Class == AnimalClass.Aves, animals))
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Ordern: {animal.Order}");
            }
            Console.WriteLine("Herbivoros:");
            foreach (var animal in new AnimalFilter().FilterAnimal<Animal>((o) => o.Order == AnimalOrder.Herbivoro, animals))
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Ordern: {animal.Order}");
            }

            Console.WriteLine("Clase And order:");
            foreach (var animal in new AnimalFilter().FilterAnimal<Animal>((o) => o.Order == AnimalOrder.Herbivoro && o.Class == AnimalClass.Mamiferos, animals))
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Ordern: {animal.Order}");
            }

            Console.ReadLine();


        }
    }
}
