using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemo.Models.Enums;
using BuilderDemo.Models.Interfaces;

namespace BuilderDemo.Models
{
    class SuperSandwichBuilder : ISandwichBuilder
    {
        public Sandwich Build()
        {
            return
                SandwichBuilder
                .Sandwich()
                .WithBreadType(BreadType.Wheat)
                .WithMeat(MeatType.Salami)
                .WithCheese(CheeseType.Provolone)
                .WithVegetables(new List<string> { "Tomato", "Onion", "Lettuce", "Cucumber" })
                .WithMayo()
                .Build();
        }
    }
}
