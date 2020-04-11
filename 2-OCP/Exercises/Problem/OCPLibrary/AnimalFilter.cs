using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OCPLibrary
{
    public class AnimalFilter : IAnimalFilter
    {
        public List<TAnimal> FilterAnimal<TAnimal>(Func<TAnimal,bool> filtro, List<TAnimal> animales) where TAnimal : class
        {
            return animales.Where(filtro).ToList();

        }
    }
}
