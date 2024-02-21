using Entities;
using System.Collections.Generic;

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
        
        //passando a minha função como parametro para o metodo RemoveAll - 1 maneira de fazer
        list.RemoveAll(ProductTest);
        
        //Outra maneira de fazer a mesma função, é com lambda, como está abaixo
        list.RemoveAll(p => p.Price >= 100.0)
        
        //retornando os valores para o usuario na tela os itens que custam menos de 100 reais
        foreach (Product p in list)
        {
            System.Console.WriteLine(p);
        }
    }
    //Predicate, passando um objeto e retornando um valor bool
    public static bool ProductTest(Product p)
    {
        //retornando todos os iten que são maiores que 100
        return p.Price >= 100.0;
    }
}
