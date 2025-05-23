namespace AnimalSound;

public interface IFlyable
{
    void Fly();
    int MaxFlightAltitude { get; }
}