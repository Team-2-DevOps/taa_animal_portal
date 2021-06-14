using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Debby", Age = 20, Description = "If I would be a dog, I would be a husky because sometimes I'm stubborn" },
            new Animal { Id = 2, Name = "Ali", Age = 44, Description = "If I would be a dog, I would be a bear. ^_^" },
            new Animal { Id = 3, Name = "Brandon", Age = 20, Description = "Shiny and glasslike" },
        };
    }
}
