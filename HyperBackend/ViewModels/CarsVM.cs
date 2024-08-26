#nullable disable
namespace HyperBackend.ViewModels;

public class CarsVM
{
    public int VIN { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public byte Wheels { get; set; }
    public bool IsHeadlights { get; set; }
}