using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Yamed_Terminal_Service_GetPatient.Models;

namespace Yamed_Terminal_Service_GetPatient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGetPatient
    {

        //[OperationContract]
        //string GetData(int value);

        [OperationContract]
        Patient GetPatient(string NPolis);
    }
}
