using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design
{
    class PdfReport : ReportTemplate
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching Data for PDF Report");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting Data for PDF Report");
        }
    }
}
