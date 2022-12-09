using System;

public interface ITaxCalculator { int calculateEmpTax(int empID); }
public class TaxCalculator : ITaxCalculator
{
    ILog _log;
    ISalary _salary;
  
    public TaxCalculator(ISalary salary,ILog log)
    {
        _salary = salary;
        _log = log;
    }

    public int calculateEmpTax(int empID)
    {
        _log.Log(string.Format("EMPLOYEE ID : {0}", empID));
        return _salary.calculateEmpTax(empID);
    }

}