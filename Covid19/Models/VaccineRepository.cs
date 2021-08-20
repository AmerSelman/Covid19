using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class VaccineRepository: IVaccineRepository
    {
        private readonly AppDbContext _appDbContext;

        public VaccineRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Vaccine> AllVaccines => _appDbContext.Vaccines;

    }
}
