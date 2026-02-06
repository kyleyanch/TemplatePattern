namespace ReportGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PdfReportGenerator pdfReportGenerator = new PdfReportGenerator();
            ExcelReportGenerator excelReportGenerator = new ExcelReportGenerator();

            pdfReportGenerator.GenerateReport();
            Console.WriteLine();
            excelReportGenerator.GenerateReport();
        }
    }
}
