using Classes;

internal class Program
{
    static void Main(string[] args)
    {
        //Classes
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "İstanbul";
        customer.Id = 1;
        customer.FirstName = "Rümeysa";
        customer.LastName = "Furkan";

        Customer customer2 = new Customer
        {
            Id = 2, City = "Bursa", FirstName ="Furkan", LastName ="Ayaz"
        };

        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
    }
}