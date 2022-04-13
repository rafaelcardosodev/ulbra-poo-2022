namespace DefaultNamespace;

public class Customer
{
    public Customer(String Name, String Phone)
    {
        this.Name = Name;
        this.Phone = Phone;
        this.Billings = new List<Billing>();
    }
    
    public int Id { get; set; }
    public String Name { get; set; }
    public String Phone { get; set; }
    public List<Billing> Billings { get; set; }
}