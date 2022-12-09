using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Unity;
using Unity.Wcf;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeTax
    {

        [OperationContract]
        int CalculateTax(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    public class Wcfservicehostfactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<ILog, logger>();
            container.RegisterType<ISalary, salary>();


            container.RegisterType<ITaxCalculator, TaxCalculator>();
            container.RegisterType<IEmployeeTax, EmployeeTax>();
        }
    }
}
