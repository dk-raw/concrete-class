using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConcreteClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            do
            {
                Console.WriteLine("Type an employee's name");

                name = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(name));

            MyDatabase db = new MyDatabase();

            Employees e1 = new Employees();

            e1.Name = name;

            db.Employees.Add(e1);

            db.SaveChanges();

            foreach (var employee in db.Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
    class Employees
    {
        public int Id { get; set; }

        public string Name { get; set; } 
    }
    class MyDatabase : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
    }
}
