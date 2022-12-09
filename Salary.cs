using System;

public interface ISalary { int calculateEmpTax(int empID); }
public class salary : ISalary
{
    ILog _log;
   
    public salary(ILog log)
    {
        _log = log;
    }

    public int calculateEmpTax(int empID)
    {
        _log.Log(string.Format("EMPLOYEE ID : {0}", empID));
        return 500;
    }

}