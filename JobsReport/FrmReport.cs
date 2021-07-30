using EFRepositories;
using JobsReport.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JobsReport
{
    public partial class FrmReport : Form
    {
        private JobReportViewModel viewModel;

        public FrmReport()
        {
            InitializeComponent();

            viewModel = new JobReportViewModel(new EFJobReportRepository(new JobsReportContext()));

            viewModel.Pobierz();

            cbLokal.DataSource = viewModel.NazwyLokali;
        }

        private void btZatwierdz_Click(object sender, EventArgs e)
        {
            viewModel.SearchCriteria.NazwaLokalu = cbLokal.Text;
            viewModel.SearchCriteria.DataOd = dtDataOd.Value;
            viewModel.SearchCriteria.DataDo = dtDataDo.Value;

            viewModel.Zatwierdz();

            var reports = viewModel.JobReports.Select(r => new
            {
                Nazwa = r.NazwaPrac,
                Data = r.DataIGodzina.ToString("yyyy-MM-dd"),
                Godzina = r.DataIGodzina.ToShortTimeString(),
                Użytkownik = r.NazwaUzytkownika,
                Lokal = r.NazwaLokalu
            }).ToList();

            dgvJobReports.DataSource = reports;
        }
    }
}
