namespace EcommerceSample.Domain.Entities;
public class Order : BaseEntity
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}   