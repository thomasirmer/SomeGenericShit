namespace SomeGenericShit
{
    using System;
    using Newtonsoft.Json;
    using SomeGenericShit.DTO;
    using SomeGenericShit.Event;

    class Program
    {
        static void Main(string[] args)
        {
            var specificEvent = new SpecificEvent { EventId = Guid.NewGuid(), Name = "I'm very specific" };
            // var baseEvent = (EventBase<DtoBase>)specificEvent; // geht nicht!
            var baseEvent = (IEvent<DtoBase>)specificEvent; // è voila!

            var json = JsonConvert.SerializeObject(baseEvent.ToDto());
            Console.WriteLine(json);
        }
    }
}