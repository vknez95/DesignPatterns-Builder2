using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemo.Models.Enums;
using BuilderDemo.Models.Interfaces;

namespace BuilderDemo.Models
{
    public class MySandwichBuilder : ISandwichBuilder
    {
        public Sandwich Build()
        {
            return
                SandwichBuilder
                .Sandwich()
                .WithBreadType(BreadType.White)
                .AndToasted()
                .WithMeat(MeatType.Turkey)
                .WithCheese(CheeseType.Cheddar)
                .WithVegetables(new List<string> { "Tomato", "Onion" })
                .WithNoMayo()
                .WithMustard()
                .Build();
        }
        // public override void AddCondiments()
        // {
        //     sandwich.HasMayo = false;
        //     sandwich.HasMustard = true;
        // }
    }
}
