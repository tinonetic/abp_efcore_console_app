using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MyApp
{
    public class MyEntity : Entity<Guid>
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }
    }
}
