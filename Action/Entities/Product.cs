namespace Entities;

class Product
{
    //prop da classe
    public string Name { get; set; }
    public double Price { get; set; }
    //construtor
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
    //metodo ToString
    public override string ToString()
    {
        return Name +", " + Price.ToString("F2");
    }
}
