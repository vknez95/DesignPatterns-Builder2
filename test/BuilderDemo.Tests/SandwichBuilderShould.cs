using BuilderDemo.Models;
using Xunit;

namespace BuilderDemo.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class SandwichBuilderShould
    {
        private readonly SandwichBuilderStub stub = new SandwichBuilderStub();

        [Fact]
        public void CreateNewSandwich()
        {
            stub.CreateNewSandwich();
            Sandwich sandwich = stub.GetSandwich();

            Assert.NotNull(sandwich);
        }
    }
}
