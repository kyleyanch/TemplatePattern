using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    internal class ExcelReportGenerator : ReportGenerator
    {
        //protected override void FormatReport()
        //{
        //    Console.WriteLine("Formatting report as Excel...");
        //}
        protected override void ExportReport()
        {
            Console.WriteLine("Saving report as Excel...");
        }
        protected override bool needsSpecialFormat()
        {
            return true;
        }
        protected override void doSpecialFormat()
        {
            Console.WriteLine("Applying special Excel formatting...");
        }

    }
}
