using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemo.Models.Enums;
using BuilderDemo.Models.Interfaces;

namespace BuilderDemo.Models
{
    public class SandwichBuilder : IHasMustard, IHasMayo, IVegetablesHolder, ICheeseHolder, IMeatHolder,
        IIsToasted, IBreadTypeHolder, ISandwichBuilder
    {
        private BreadType breadType { get; set; }
        private bool isToasted { get; set; }
        private MeatType meatType { get; set; }
        private CheeseType cheeseType { get; set; }
        private IEnumerable<string> vegetables { get; set; }
        private bool hasMayo { get; set; }
        private bool hasMustard { get; set; }

        private SandwichBuilder()
        {
        }

        public static IBreadTypeHolder Sandwich() => new SandwichBuilder();

        public IMeatHolder WithBreadType(BreadType type) =>
            new SandwichBuilder()
            {
                breadType = type
            };

        public IMeatHolder AndToasted() =>
            new SandwichBuilder()
            {
                breadType = this.breadType,
                isToasted = true
            };

        public ICheeseHolder WithMeat(MeatType type) =>
            new SandwichBuilder()
            {
                breadType = this.breadType,
                isToasted = this.isToasted,
                meatType = type
            };

        public IVegetablesHolder WithCheese(CheeseType type) =>
            new SandwichBuilder()
            {
                breadType = this.breadType,
                isToasted = this.isToasted,
                meatType = this.meatType,
                cheeseType = type
            };

        public IHasMayo WithVegetables(IEnumerable<string> vegetables) =>
            new SandwichBuilder()
            {
                breadType = this.breadType,
                isToasted = this.isToasted,
                meatType = this.meatType,
                cheeseType = this.cheeseType,
                vegetables = vegetables
            };

        public IHasMustard WithMayo() =>
            new SandwichBuilder()
            {
                breadType = this.breadType,
                isToasted = this.isToasted,
                meatType = this.meatType,
                cheeseType = this.cheeseType,
                vegetables = vegetables,
                hasMayo = true
            };

        public IHasMustard WithNoMayo() => this;

        public ISandwichBuilder WithNoCondiments() => this;

        public ISandwichBuilder WithMustard() =>
            new SandwichBuilder()
            {
                breadType = this.breadType,
                isToasted = this.isToasted,
                meatType = this.meatType,
                cheeseType = this.cheeseType,
                vegetables = this.vegetables,
                hasMayo = this.hasMayo,
                hasMustard = true
            };

        public Sandwich Build()
        {
            Sandwich sandwich = new Sandwich();

            sandwich.BreadType = this.breadType;
            sandwich.IsToasted = this.isToasted;
            sandwich.MeatType = this.meatType;
            sandwich.CheeseType = this.cheeseType;
            sandwich.HasMayo = this.hasMayo;
            sandwich.HasMustard = this.hasMustard;

            foreach (string vegetable in this.vegetables)
                sandwich.VegetableList.Add(vegetable);

            return sandwich;
        }
    }
}
