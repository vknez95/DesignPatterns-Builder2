namespace BuilderDemo.Models.Interfaces
{
    public interface IHasMustard : ISandwichBuilder
    {
        ISandwichBuilder WithMustard();
    }
}