namespace EcommerceSample.Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; } = default!;
    public int Price { get; set; }
}