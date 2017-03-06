using BuilderDemo.Models;
using Xunit;

namespace BuilderDemo.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class SandwichShould
    {
        private readonly ClubSandwichBuilder stub = new ClubSandwichBuilder();

        [Fact]
        public void DisplaySandwich()
        {
            SandwichMaker maker = new SandwichMaker(stub);
            maker.BuildSandwich();
            Sandwich sandwich = maker.GetSandwhich();

            sandwich.Display();

            Assert.True(true);
        }
    }
}
