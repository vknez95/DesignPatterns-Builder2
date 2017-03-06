using System;
using BuilderDemo.Models;

namespace BuilderDemo.Tests
{
    public class SandwichBuilderStub : SandwichBuilder
    {
        public override void AddCondiments()
        {
            throw new NotImplementedException();
        }

        public override void ApplyMeatAndCheese()
        {
            throw new NotImplementedException();
        }

        public override void ApplyVegetables()
        {
            throw new NotImplementedException();
        }

        public override void PrepareBread()
        {
            throw new NotImplementedException();
        }
    }
}