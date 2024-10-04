using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design
{
    class ExcelReport : ReportTemplate
    {
        // Concrete implementation for Excel report
        protected override void FetchData()
        {
            Console.WriteLine("Fetching Data for Excel Report");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting Data for Excel Report");
        }
    }
}
