namespace K2.Shared.Interfaces.Models
{
    public interface IIdentified<T>
    {
        T Id { get; set; }
    }

    public interface IIdentified : IIdentified<string>
    {
        
    }
}
