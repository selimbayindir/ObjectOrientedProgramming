



Customer customer1 = new(1,"Selim","BAYINDIR", 12345678911);
Customer customer2 = new(2,"Selim","BAYINDIR", 12345678911);
Customer customer3 = new(3,"Selim","BAYINDIR", 12345678911);
Customer customer4 = new(4,"Selim","BAYINDIR", 12345678911);

CreditManager manager = new();
manager.Calculate();

CustomerManager manager1 = new(customer1);
Console.WriteLine("------------");
manager1.Save(customer1);
Console.WriteLine("------------");

class CreditManager
{
  public  void Calculate()
    {
        Console.WriteLine("Hesaplandı..");       
    }
    public void Save()
    {
        Console.WriteLine("Kredi Verildi..");
    }
}

class Customer 
{
    public Customer()
    {
        Console.WriteLine("Müşteri Nesne Oluştu");
    }

    public Customer(int ıd, string firstName, string lastName, long nationalIdentity)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
    }

    public int Id { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public long NationalIdentity { get; set; }
    public string TaxNumber { get; set; }
}

class CustomerManager
{
    private Customer _customer;

    public CustomerManager(Customer customer)
    {
        _customer = customer;
    }

    public void Save(Customer customer)
    {

        Console.WriteLine("Müşteri Kaydedildi..");
    }
}