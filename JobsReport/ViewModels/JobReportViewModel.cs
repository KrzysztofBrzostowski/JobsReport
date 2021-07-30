using IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsReport.ViewModels
{
    public class JobReportViewModel
    {
        public JobReportSearchCriteria SearchCriteria { get; set; }

        public IList<JobReport> JobReports { get; set; }

        public IList<string> NazwyLokali { get; set; }

        private readonly IJobReportRepository jobReportRepository;

        public JobReportViewModel(IJobReportRepository jobReportRepository)
        {
            this.jobReportRepository = jobReportRepository;

            SearchCriteria = new JobReportSearchCriteria();
        }

        public void Pobierz()
        {
            NazwyLokali = jobReportRepository.PobierzNazwyLokali();
        }

        public void Zatwierdz()
        {
            JobReports = jobReportRepository.Get(SearchCriteria);
        }
    }
}
