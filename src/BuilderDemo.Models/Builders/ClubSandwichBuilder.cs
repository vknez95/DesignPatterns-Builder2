using System;
using System.Collections.Generic;
using BuilderDemo.Models.Enums;
using BuilderDemo.Models.Interfaces;

namespace BuilderDemo.Models
{
    public class ClubSandwichBuilder : ISandwichBuilder
    {
        public Sandwich Build()
        {
            return
                SandwichBuilder
                .Sandwich()
                .WithBreadType(BreadType.White)
                .AndToasted()
                .WithMeat(MeatType.Turkey)
                .WithCheese(CheeseType.Swiss)
                .WithVegetables(new List<string> { "Tomato", "Onion", "Lettuce" })
                .WithMayo()
                .WithMustard()
                .Build();
        }
    }
}