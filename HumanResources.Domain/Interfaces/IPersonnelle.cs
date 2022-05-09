using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Interfaces
{
    public interface IPersonnelle
    {
        decimal Salary { get; set; }
        DateTime BirthDate { get; set; }
        DateTime HireDate { get; set; }
    }
}
