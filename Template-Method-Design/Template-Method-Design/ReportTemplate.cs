using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design
{
    abstract class ReportTemplate
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Report Header");
            FetchData();
            FormatData();
            DisplayReport();
        }

        // Abstract methods to be implemented by concrete classes
        protected abstract void FetchData();
        protected abstract void FormatData();

        // Common implementation
        private void DisplayReport()
        {
            Console.WriteLine("Displaying Report");
        }

    }
}
