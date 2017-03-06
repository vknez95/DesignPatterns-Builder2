using BuilderDemo.Models.Enums;

namespace BuilderDemo.Models.Interfaces
{
    public interface IBreadTypeHolder
    {
        IMeatHolder WithBreadType(BreadType type);
    }
}