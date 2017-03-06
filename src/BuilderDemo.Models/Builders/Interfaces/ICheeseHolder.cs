using BuilderDemo.Models.Enums;

namespace BuilderDemo.Models.Interfaces
{
    public interface ICheeseHolder
    {
        IVegetablesHolder WithCheese(CheeseType type);
    }
}