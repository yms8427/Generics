using BilgeAdam.OOP.GenericTypes.App.Extensions;
using BilgeAdam.OOP.GenericTypes.Builder;
using BilgeAdam.OOP.GenericTypes.Concretes;
using BilgeAdam.OOP.GenericTypes.Helpers;
using System;
using System.Collections.Generic;

namespace BilgeAdam.OOP.GenericTypes.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            QueryFilter();
        }

        private static void QueryFilter()
        {
            var query = new QueryBuilder<Category>("Categories")
                                               .WithColumn("Id")
                                               .WithColumn("CategoryName")
                                               .WithColumn("Description")
                                               //.WithFilter(sdfjklsdf)
                                               .WithOrder("CategoryName", Direction.DESC)
                                               .Build();
            Console.WriteLine(query);
            Console.ReadLine();
        }

        private static void ProjectBuilder()
        {
            var project = new ProjectBuilder()
                                              .WithName("Sıfır Atık")
                                              .WithStartDate(new DateTime(2018, 10, 1))
                                              .WithDueDate(new DateTime(2019, 2, 1))
                                              .WithSourceCount(5)
                                              .WithBudget(4000000)
                                              .Build();

            var builder = new ProjectBuilder();

            Console.Write("Proje Adı.................: ");
            builder.WithName(Console.ReadLine());

            Console.Write("Kaynak Sayısı.............: ");
            builder.WithSourceCount(int.Parse(Console.ReadLine()));

            Console.Write("Başlangıç Tarihi..........: ");
            builder.WithStartDate(DateTime.Parse(Console.ReadLine()));

            Console.Write("Bitiş Tarihi..............: ");
            builder.WithDueDate(DateTime.Parse(Console.ReadLine()));

            Console.Write("Bütçesi...................: ");
            builder.WithBudget(decimal.Parse(Console.ReadLine()));

            var p = builder.Build();
        }

        private static void MoneyTransfer()
        {
            var mt = new MoneyTransfer<MobilePayment>("26237378", 1000);
            mt.Send();
        }

        private static void HashSetCustomization()
        {
            var products = new HashSet<Product>(new ProductComparer());

            var p1 = new Product { Id = 1, Name = "Ekmek", Price = 1.5M };
            var p2 = new Product { Id = 2, Name = "Su", Price = 3.75M };
            var p3 = new Product { Id = 3, Name = "Yağ", Price = 75M };
            var p4 = new Product { Id = 4, Name = "Sabun", Price = 3M };
            var p5 = new Product { Id = 5, Name = "Çikolata", Price = 3M };
            var p6 = new Product { Id = 1, Name = "Ekmek", Price = 1.5M };
            var p7 = new Product { Id = 2, Name = "Susu", Price = 1.5M };

            products.AddRange(new Product[] { p1, p2, p3, p4, p5, p6, p7 });
            Print(products);
            Console.ReadKey();
        }

        private static void Print(HashSet<Product> products)
        {
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id} -) {p.Name} {p.Price}");
            }
        }
    }
}