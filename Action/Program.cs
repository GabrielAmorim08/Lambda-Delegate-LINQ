using System.Collections.Generic;
using Entities;
class Program
{
    public static void Main(string[] args)
    {
        //instanciando uma list Product
        List<Product> list = new List<Product>();
        //Adicionando itens a lista
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("Hd Case", 80.00));


        //Versões para aumentar 10% o valor dos produtos
        //utilizando o ForEach dentro da list, passando minha função void como parametro
        list.ForEach(UpdatePrice);
        //Criando um Action passando 1 parametro somente
        Action<Product> act = UpdatePrice;
        list.ForEach(act);
        //Função lambda dentro do act
        Action<Product> actL = p => {p.Price =+ p.Price *0.1;};
        //Ou podemos utilizar a função lambda dentro do ForEach, nesse caso não precisamos definir uma outra função de fora
        list.ForEach( p => {p.Price += p.Price *0.1;});

        
        foreach (Product p in list)
        {
            System.Console.WriteLine(p);
        }
    }
    static void UpdatePrice(Product p)
    {
        p.Price += p.Price*0.1;
    }
}

