using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Text;

namespace Shopp_App_.NetCore.Model
{
    public class Employes
    {
        public Employes(int id, string name, string sureName, int age, decimal salary)
        {
            Id = id;
            Name = name;
            SureName = sureName;
            Age = age;
            Salary = salary;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; private set; }
        public string SureName { get; private set; }
        public int Age { get; set; }
        public decimal Salary { get=>RealSamlary(); set { } }

        public decimal RealSamlary() 
        {
            return Salary * 25 / 100;
        }
    }
}
