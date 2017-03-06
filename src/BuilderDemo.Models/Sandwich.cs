using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemo.Models.Enums;

namespace BuilderDemo.Models
{
    public class Sandwich
    {
        public BreadType BreadType { get; internal set; }
        public bool IsToasted { get; internal set; }
        public CheeseType CheeseType { get; internal set; }
        public MeatType MeatType { get; internal set; }
        public bool HasMustard { get; internal set; }
        public bool HasMayo { get; internal set; }
        public IEnumerable<string> Vegetables => this.VegetableList;

        internal IList<string> VegetableList { get; } = new List<string>();

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", BreadType);
            if (IsToasted)
                Console.WriteLine("Toasted");
            if (HasMayo)
                Console.WriteLine("With Mayo");
            if (HasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine("Meat: {0}", MeatType);
            Console.WriteLine("Cheese: {0}", CheeseType);
            Console.WriteLine("Veggies:");
            foreach (var vegetable in Vegetables)
                Console.WriteLine("   {0}", vegetable);
        }
    }
}
