using DefaultNamespace;

namespace SistemaCobranca.Repository;

public class CustomerRepository
{

    private List<Customer> customers = new List<Customer>();

    public CustomerRepository(){}

    public List<Customer> getAll()
    {
        return customers;
    }

    public Customer GetById(int id)
    {
        return customers.Find(c => c.Id.Equals(id));
    }

    public bool Save(Customer customer)
    {
        try
        {
            int id = customers.Count;
            id++;
            customer.Id = id;
            customers.Add(customer);
            return true;
        }
        catch (Exception e)
        {   
            Console.WriteLine(e);
            throw;
        }
    }

    public bool Update(int id, Customer updatedCustomer)
    {
        try
        {
            Customer customer = GetById(id);
            customer.Phone = updatedCustomer.Phone;
            customer.Name = updatedCustomer.Name;
            customer.Billings = updatedCustomer.Billings;
            return true;
        }
        catch (Exception e)
        {   
            Console.WriteLine(e);
            throw;
        }
    }

    public bool Remove(int id)
    {
        try
        {
            customers.Remove(GetById(id));
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public bool SaveBilling(int idCostumer, Billing billing)
    {
        try
        {
            Customer customer = GetById(idCostumer);
            customer.Billings.Add(billing);
            return true;
        }
        catch (Exception e)
        {   
            Console.WriteLine(e);
            throw;
        }
    }

    public bool RemoveBilling(int idCustomer, int idBilling)
    {
        try
        {
            Customer customer = GetById(idCustomer);
            customer.Billings.Remove(getBillingById(customer, idBilling));
            return true;
        }
        catch (Exception e)
        {   
            Console.WriteLine(e);
            throw;
        }
    }
    
    public bool UpdateBilling(int idCustomer, Billing updatedBilling)
    {
        try
        {
            Customer customer = GetById(idCustomer);
            foreach (var billing in customer.Billings)
            {
                if (billing.Id.Equals(updatedBilling.Id))
                {
                    billing.Emission = updatedBilling.Emission;
                    billing.DueDate = updatedBilling.DueDate;
                    billing.PaymentDate = updatedBilling.PaymentDate;
                    billing.TotalPrice = updatedBilling.TotalPrice;
                }
            }
            return true;
        }
        catch (Exception e)
        {   
            Console.WriteLine(e);
            throw;
        }
    }
    

    public Billing getBillingById(Customer customer, int idBilling)
    {
        return customer.Billings.Find(b => b.Id.Equals(idBilling));
    }
}