namespace SomeGenericShit.Event
{
    using System;
    using SomeGenericShit.DTO;

    public abstract class EventBase<T> : IEvent<T> where T : DtoBase, new()
    {
        public Guid EventId { get; set; }

        public abstract T ToDto();

        protected T ToDtoBase() => new T { Id = EventId };
    }
}