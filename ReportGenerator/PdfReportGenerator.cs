using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    internal class PdfReportGenerator : ReportGenerator
    {
        protected override void FormatReport()
        {
            Console.WriteLine("Formatting report as PDF...");
        }
        protected override void ExportReport()
        {
            Console.WriteLine("Saving report as PDF...");
        }
    }
}
