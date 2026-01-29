using System.Collections.Generic;
using System;
using System.Linq;
using NuGet.Protocol.Plugins;
namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller>  Sellers{ get; set; } = new List<Seller>();

        public Department() { }

        //nao se inclui atributos que são coleções 
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSaller(Seller seller)
        {
             Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial,DateTime finail)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial,finail));
        }
    }
}
