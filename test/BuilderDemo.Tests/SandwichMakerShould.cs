using BuilderDemo.Models;
using Xunit;

namespace BuilderDemo.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class SandwichMakerShould
    {
        private readonly ClubSandwichBuilder stub = new ClubSandwichBuilder();

        [Fact]
        public void BuildAndGetSandwich()
        {
            SandwichMaker maker = new SandwichMaker(stub);
            maker.BuildSandwich();
            Sandwich sandwich = maker.GetSandwhich();

            Assert.NotNull(sandwich);
        }
    }
}
