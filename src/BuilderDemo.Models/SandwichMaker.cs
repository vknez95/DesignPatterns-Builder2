using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemo.Models.Common;
using BuilderDemo.Models.Interfaces;

namespace BuilderDemo.Models
{
    public class SandwichMaker
    {
        private readonly ISandwichBuilder builder;
        private INonEmptyObjectState<Sandwich> sandwich { get; set; } = new UninitializedObject<Sandwich>();

        public SandwichMaker(ISandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            sandwich = sandwich.Set(builder.Build());
        }

        public Sandwich GetSandwhich()
        {
            return this.sandwich.Get();
        }
    }
}
