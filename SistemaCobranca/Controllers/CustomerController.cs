using SistemaCobranca.Services;
using SistemaCobranca.Views;

namespace SistemaCobranca.Controllers;

public class CustomerController
{
    public void openView()
    {
        CustomerView.Menu(new CustomerService());
    }

    public void setBilling()
    {
        
    }
}