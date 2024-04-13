namespace CarDealership.Models;

public class ServiceHistory
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public DateTime ServiceDate { get; set; }
    public string Description { get; set; }
    public decimal Cost { get; set; }
}