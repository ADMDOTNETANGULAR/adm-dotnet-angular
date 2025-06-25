using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.SRP
{
    //ReportGenerator class that is responsible for both generating reports and formatting them. This violates SRP.
    //public  class ReportGenerator
    //{
    //    public void GenerateReport()
    //    {
    //        //Generate Report logic
    //    }
    //    public void FormatReport()
    //    {
    //        //Format report logic
    //    }
    //}
    /*
     To adhere to SRP, we can split this into two classes: 
    ReportGenerator responsible for generating reports 
    and ReportFormatter responsible for formatting reports.
     */
    public  class ReportGenerator
    {
        public void GenerateReport()
        {
            //Generate Report logic
        }
        
    }
    public partial class ReportFormater
    {
        
        public void FormatReport()
        {
            //Format report logic
        }
    }
    internal class Demo1
    {
    }
}
