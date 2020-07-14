namespace SomeGenericShit.Event
{
    using SomeGenericShit.DTO;

    public class SpecificEvent : EventBase<SpecificDto>
    {
        public string Name { get; set; }

        public override SpecificDto ToDto()
        {
            var dto = ToDtoBase();
            dto.Name = Name;
            return dto;
        }
    }
}