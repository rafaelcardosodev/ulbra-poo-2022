using DefaultNamespace;
using SistemaCobranca.Repository;

namespace SistemaCobranca.Services;

public class CustomerService
{
    private CustomerRepository customerRepository;

    public CustomerService()
    {
        customerRepository = new CustomerRepository();
    }

    public Customer GetById(int id)
    {
        return customerRepository.GetById(id);
    }
    
    public List<Customer> getAll()
    {
        return customerRepository.getAll();
    }

    public bool Save(Customer customer)
    {
        return customerRepository.Save(customer);
    }

    public bool Update(int id, Customer updatedCustomer)
    {
       return customerRepository.Update(id, updatedCustomer);
    }

    public bool Remove(int id)
    {
        return customerRepository.Remove(id);
    }

    public bool SaveBilling(int idCustomer, Billing billing)
    {
        return customerRepository.SaveBilling(idCustomer, billing);
    }
}