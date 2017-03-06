namespace BuilderDemo.Models.Common
{
    internal interface INonEmptyObjectState<T>
    {
        INonEmptyObjectState<T> Set(T value);
        T Get();
    }
}