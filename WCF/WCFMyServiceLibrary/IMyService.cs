using System.ServiceModel;

namespace WCFMyServiceLibrary
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string Method1(string x);

        [OperationContract]
        string Method2(string x);
    }
}
