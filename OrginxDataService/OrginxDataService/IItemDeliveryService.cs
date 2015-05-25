using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrginxDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IItemDeliveryService" in both code and config file together.
    [ServiceContract]
    public interface IItemDeliveryService
    {
        [OperationContract]
        void addDelivery(ItemDeliveryClass delivery);
    }
}
