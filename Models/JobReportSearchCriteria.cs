using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JobReportSearchCriteria : Base
    {
        public string NazwaLokalu { get; set; }
        public DateTime DataOd { get; set; }
        public DateTime DataDo { get; set; }
    }
}
