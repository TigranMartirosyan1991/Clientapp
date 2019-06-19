using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Clientapp
{

    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        string gettikotime(string text);
        string gettikotime();
    }
}
