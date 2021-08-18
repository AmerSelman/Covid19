using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public interface IVaccineRepository
    {
        IEnumerable<Vaccine> AllVaccines { get; }
    }
}
