using BuilderDemo.Models.Enums;

namespace BuilderDemo.Models.Interfaces
{
    public interface IMeatHolder : IIsToasted
    {
        ICheeseHolder WithMeat(MeatType type);
    }
}