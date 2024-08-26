using HyperBackend.Enums;

namespace HyperBackend.Entities;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; } = "_brand";
    public Color Color { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}