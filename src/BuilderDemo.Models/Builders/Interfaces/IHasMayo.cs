namespace BuilderDemo.Models.Interfaces
{
    public interface IHasMayo : ISandwichBuilder
    {
        IHasMustard WithMayo();
        IHasMustard WithNoMayo();
        ISandwichBuilder WithNoCondiments();
    }
}