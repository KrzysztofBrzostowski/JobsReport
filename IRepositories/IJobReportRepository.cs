using Models;
using System.Collections.Generic;

namespace IRepositories
{
    public interface IJobReportRepository
    {
        IList<JobReport> Get(JobReportSearchCriteria searchCriteria);

        IList<string> PobierzNazwyLokali();
    }
}
