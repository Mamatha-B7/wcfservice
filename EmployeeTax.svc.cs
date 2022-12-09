using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeTax : IEmployeeTax
    {
        private readonly ILog _log;
        private readonly ITaxCalculator _taxCalculator;
        
        public EmployeeTax(ILog log, ITaxCalculator taxCalculator)
        {
            _log = log;
            _taxCalculator = taxCalculator;
        }

        public int CalculateTax(int value)
        {
            int tax = _taxCalculator.calculateEmpTax(value);
            return tax;
        }

    }

}
