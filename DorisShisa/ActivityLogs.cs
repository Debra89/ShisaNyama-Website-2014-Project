using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DorisShisa
{
    public class ActivityLogs
    {
        string email;
        string activity;
        DateTime activitydate;

        [DataMember]

        public string Email
        {

            get { return email; }

            set { email = value; }

        }
        [DataMember]

        public string Activity
        {

            get { return activity; }

            set { activity = value; }

        }

        [DataMember]

        public DateTime Activitydate
        {

            get { return activitydate; }

            set { activitydate = value; }

        }
    }
}