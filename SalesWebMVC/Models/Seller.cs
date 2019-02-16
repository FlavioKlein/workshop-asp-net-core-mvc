using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department, int departmentId)
        {            
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
            DepartmentId = departmentId;
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {            
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sale)
        {
            Sales.Add(sale);
        }

        public void RemoveSales(SalesRecord sale)
        {
            Sales.Remove(sale);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //Usando Linq
            return Sales.Where(sales => sales.Date >= initial && sales.Date <= final).Sum(sales => sales.Amount);

            /*Programação tradicional
            double total = 0.0;
            foreach (var item in Sales)
            {
                if (item.Date >= initial && item.Date <= final)
                {
                   total += item.Amount;
                }
            }
            return total;
            */
        }
    }
}
