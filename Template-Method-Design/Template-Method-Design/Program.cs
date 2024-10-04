using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportTemplate pdfReport = new PdfReport();
            pdfReport.GenerateReport();

            ReportTemplate excelReport = new ExcelReport();
            excelReport.GenerateReport();

            Console.ReadLine();
        }
    }
}
