using System.Collections.Generic;

namespace BuilderDemo.Models.Interfaces
{
    public interface IVegetablesHolder
    {
        IHasMayo WithVegetables(IEnumerable<string> vegetables);
    }
}