using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace DorisShisa
{
    public class SubscriptionDetails
    {
        string email = string.Empty;

        [DataMember]
        public string Email
        {

            get { return email; }

            set { email = value; }

        }


    }
}