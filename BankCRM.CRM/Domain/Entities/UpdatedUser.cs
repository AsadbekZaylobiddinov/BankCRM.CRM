using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.CRM.Domain.Entities
{
    internal class UpdatedUser
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Disease { get; set; }
        public DateTime CreationTime = DateTime.Now;
    }
}
