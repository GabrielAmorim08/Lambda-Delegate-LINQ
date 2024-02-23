﻿using System;
using System.Linq;
using Entities;
using System.Collections.Generic;

//Instanciando 3 categotias diferentes
Category c1 = new Category() {Id= 1, Name = "Tools", Tier = 2};
Category c2 = new Category() {Id= 2, Name = "Computer", Tier = 1};
Category c3 = new Category() {Id= 3, Name = "Eletronics", Tier = 1};


//instanciando uma lista e adicionando produtos nessa lista
List<Product> products = new List<Product>{
    new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
    new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
    new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
    new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
    new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
    new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
    new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
    new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
    new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
    new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
    new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
};

System.Console.WriteLine("ID | Name | Price | Type | Category");
//Consultas utilizando o LINQ com função LAMBDA
var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
Print("TIER 1 AND PRICE < 900: ", result1);

var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
Print("NAMES OF PRODUCTS FROM TOOLS: ", result2);
var result3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ",result3);

var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
Print("TIER 1 ORDER BY PRICE THEN BY NAME", result4);

var result5 = result4.Skip(2).Take(4);
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", result5);

var result6 = products.FirstOrDefault();
Console.WriteLine("First or default test1: " + result6);

var result7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
Console.WriteLine("First or default test2: " + result7);
Console.WriteLine();

var result8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("Single or default test1: " + result8);

var result9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test2: " + result9);
Console.WriteLine();

var result10 = products.Max(p => p.Price);
Console.WriteLine("Max price: " + result10);

var result11 = products.Min(p => p.Price);
Console.WriteLine("Min price: " + result11);

var result12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 Sum prices: " + result12);

var result13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Average prices: " + result13);

var result14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Category 5 Average prices: " + result14);

var result15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Category 1 aggregate sum: " + result15);
Console.WriteLine();

var result16 = products.GroupBy(p => p.Category);
foreach (IGrouping<Category, Product> group in result16) {
    Console.WriteLine("Category " + group.Key.Name + ":");
    foreach (Product p in group) {
        Console.WriteLine(p);
    }
}
Console.WriteLine();


static void Print<T> (string message, IEnumerable<T> collection)
{
    System.Console.WriteLine(message);
    foreach (T obj in collection)
    {
        System.Console.WriteLine(obj);
    }
    System.Console.WriteLine();
}
