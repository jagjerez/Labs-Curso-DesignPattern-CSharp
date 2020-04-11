using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OCPLibrary
{
    interface IAnimalFilter
    {
        List<TAnimal> FilterAnimal<TAnimal>(Func<TAnimal,bool> filtro, List<TAnimal> animales)  where TAnimal : class;
    }
}
