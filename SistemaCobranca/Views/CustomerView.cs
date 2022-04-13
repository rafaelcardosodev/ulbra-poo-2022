using System.ComponentModel.Design;
using System.Security.AccessControl;
using DefaultNamespace;
using Microsoft.VisualBasic;
using SistemaCobranca.Services;

namespace SistemaCobranca.Views;

public static class CustomerView
{
    public static void Menu(CustomerService customerService)
    {
        string opt = string.Empty;

        while (opt != "0")
        {
            Console.WriteLine("\n\nSELECT ACTION\n" +
                              "1 - Add customer\n" +
                              "2 - Update customer\n" +
                              "3 - Remove customer\n" +
                              "4 - List customers\n" +
                              "5 - Add billing\n" +
                              "0 - EXIT\n" +
                              "=======================");
            opt = Console.ReadLine();

            int id;
            switch (opt)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("\n\nSIGN UP\n" +
                                      "-------------");
                    Customer customer = createCustomerView();
                    
                    if (customerService.Save(customer))
                    {
                        Console.WriteLine("Successfully saved.");
                    }
                    else
                    {
                        Console.WriteLine("Unexpected Error. Please try again...");
                    }
                    break;
                
                case "2":
                    Console.Write("Customer ID: ");
                    id = int.Parse(Console.ReadLine());
                    Customer updatedCustomer = createCustomerView();
                    if (customerService.Update(id, updatedCustomer))
                    {
                        Console.WriteLine("Successfully updated.");
                    }
                    else
                    {
                        Console.WriteLine("Unexpected Error. Please try again...");
                    }
                    break;
                
                case "3":
                    Console.Write("Customer ID: ");
                    id = int.Parse(Console.ReadLine());
                    if (customerService.Remove(id))
                    {
                        Console.WriteLine("Successfully removed.");
                    }
                    else
                    {
                        Console.WriteLine("Unexpected Error. Please try again...");
                    }
                    break;
                
                case "4":
                    List<Customer> customers = customerService.getAll();
                    customers.ForEach(c =>
                        Console.Write($"Id: {c.Id} | Name: {c.Name} | " + $"Phone: {c.Phone} | Billings [ " +
                                      $"{String.Join(", ", c.Billings)}" + " ]\n"));
                    break;
                    
                case "5":
                    Console.Write("Customer ID: ");
                    int customerId = int.Parse(Console.ReadLine());
                    
                    Billing billing = createBillingView();
                    if (customerService.SaveBilling(customerId, billing))
                    { 
                        Console.WriteLine("Successfully saved.");
                    }
                    else
                    {
                        Console.WriteLine("Unexpected Error. Please try again...");
                    }
                    break;
                
                default:
                    Console.WriteLine("invalido");
                    continue;
            }
        }
    }

    public static Customer createCustomerView()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine().Trim();
        Console.Write("Phone: ");
        string phone = Console.ReadLine().Trim();
        
        Customer customer = new Customer(name, phone);
        return customer;
    }

    public static Billing createBillingView()
    {
        Console.Write("Billing ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Due Date: ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        
        DateTime emission = DateTime.Now;

        Console.Write("Total Price: ");
        double totalPrice = double.Parse(Console.ReadLine());
        
        Console.Write("Payment Date: ");
        DateTime paymentDate = DateTime.Parse(Console.ReadLine());

        Billing billing = new Billing(id, dueDate, emission, totalPrice, paymentDate);
        return billing;
    }
}