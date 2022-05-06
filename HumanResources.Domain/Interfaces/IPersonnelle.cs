using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Interfaces
{
    public interface IPersonnelle
    {
        string Address { get; set; }
        string City { get; set; }
        string Country { get; set; }
        decimal Salary { get; set; }
        DateTime BirthDate { get; set; }
        DateTime HireDate { get; set; }
    }
}
