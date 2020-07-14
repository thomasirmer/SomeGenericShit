namespace SomeGenericShit.Event
{
    public interface IEvent<out T>
    {
        T ToDto();
    }
}