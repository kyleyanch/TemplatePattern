using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            FetchData();
            FormatReport();
            ExportReport();
        }
        protected virtual void FetchData()
        {
            Console.WriteLine("Fetching data...");
            Console.WriteLine("Data fetched successfully.");
        }
        protected virtual void FormatReport()
        {
            bool thing = needsSpecialFormat();
            if (thing)
                doSpecialFormat();

            Console.WriteLine("Formatting report...");
        }
        protected virtual void ExportReport()
        {
            Console.WriteLine("Saving report...");
        }
        protected virtual bool needsSpecialFormat()
        {
            // Default implementation
            return true;
        }
        protected virtual void doSpecialFormat()
        {
            //default implementation - nothing
        }
    }
}
