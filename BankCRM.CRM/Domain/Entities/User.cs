using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.CRM.Domain.Entities
{
    internal class User
    {
        public User()
        {
            id();
            FirstName();
            LastName();
            age();
            disease();
        }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Disease { get; set; }
        public DateTime CreationTime = DateTime.Now;
        public void id()
        {
            Console.Write("ID = ");
            this.Id = Convert.ToInt32(Console.ReadLine());
        }
        public void FirstName()
        {
            Console.Write("Name = ");
            this.Name = Console.ReadLine();
        }
        public void LastName()
        {
            Console.Write("Surname = ");
            this.Surname = Console.ReadLine();
        }
        public void age()
        {
            Console.Write("Age = ");
            this.Age = Convert.ToInt32(Console.ReadLine());
        }
        public void disease()
        {
            Console.Write("Disease = ");
            this.Disease = Console.ReadLine();
        }
    }
}
