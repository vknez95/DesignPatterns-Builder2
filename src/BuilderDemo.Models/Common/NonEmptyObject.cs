using System;

namespace BuilderDemo.Models.Common
{
    internal class NonEmptyObject<T> : INonEmptyObjectState<T>
    {
        private readonly T obj;

        public NonEmptyObject(T obj)
        {
            this.obj = obj;
        }

        public T Get()
        {
            return this.obj;
        }

        public INonEmptyObjectState<T> Set(T value) => new NonEmptyObject<T>(value);
    }
}