using System;

namespace BuilderDemo.Models.Common
{
    internal class UninitializedObject<T> : INonEmptyObjectState<T>
    {
        public T Get()
        {
            throw new InvalidOperationException();
        }

        public INonEmptyObjectState<T> Set(T value) => new NonEmptyObject<T>(value);
    }
}