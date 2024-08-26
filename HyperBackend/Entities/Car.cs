namespace HyperBackend.Entities;

public class Car : Vehicle 
{
    public int VIN { get; set; }
    public byte Wheels { get; set; }
    public bool IsHeadlights { get; set; }
}