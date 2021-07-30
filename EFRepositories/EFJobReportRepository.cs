using IRepositories;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace EFRepositories
{
    public class EFJobReportRepository : IJobReportRepository
    {
        private readonly JobsReportContext context;

        public EFJobReportRepository(JobsReportContext context)
        {
            this.context = context;
        }

        public IList<JobReport> Get(JobReportSearchCriteria searchCriteria)
        {
            return context.JobReports
                .AsNoTracking()
                .Where(p => p.NazwaLokalu == searchCriteria.NazwaLokalu && p.DataIGodzina >= searchCriteria.DataOd && p.DataIGodzina <= searchCriteria.DataDo).ToList();
        }

        public IList<string> PobierzNazwyLokali()
        {
            return context.JobReports.AsNoTracking().Select(p => p.NazwaLokalu).Distinct().ToList();
        }
    }
}
