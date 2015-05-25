using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
    public class ItemDeliveryClass
    {
        private DateTime sendDate;

        public DateTime SendDate
        {
            get { return sendDate; }
            set { sendDate = value; }
        }


        private string deliveryId;

        public string DeliveryId
        {
            get { return deliveryId; }
            set { deliveryId = value; }
        }
        private int sendClietnId;

        public int SendClietnId
        {
            get { return sendClietnId; }
            set { sendClietnId = value; }
        }
        private int recieveClientId;

        public int RecieveClientId
        {
            get { return recieveClientId; }
            set { recieveClientId = value; }
        }
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private DateTime sentDate;

        public DateTime SentDate
        {
            get { return sentDate; }
            set { sentDate = value; }
        }
        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        private int localBranch;

        public int LocalBranch
        {
            get { return localBranch; }
            set { localBranch = value; }
        }
        private int worldBranch;

        public int WorldBranch
        {
            get { return worldBranch; }
            set { worldBranch = value; }
        }
        private int salesPerson;

        public int SalesPerson
        {
            get { return salesPerson; }
            set { salesPerson = value; }
        }
        private int deliveryPerson;

        public int DeliveryPerson
        {
            get { return deliveryPerson; }
            set { deliveryPerson = value; }
        }



    }
}
