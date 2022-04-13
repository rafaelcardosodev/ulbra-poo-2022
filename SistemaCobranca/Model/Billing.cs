namespace DefaultNamespace;

public class Billing
{
    public Billing(int id, DateTime dueDate, DateTime emission, double totalPrice, DateTime paymentDate)
    {
        this.Id = id;
        this.DueDate = dueDate;
        this.Emission = emission;
        this.TotalPrice = totalPrice;
        this.PaymentDate = paymentDate;
    }
    
    public int Id { get; set; }
    public DateTime DueDate {get; set; }
    public DateTime Emission { get; set; }
    public double TotalPrice { get; set; }
    public DateTime PaymentDate { get; set; }
    
    public override string ToString()
    {
        return $"Id: {this.Id} Price: {this.TotalPrice}";
    }
}