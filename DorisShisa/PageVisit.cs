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
    public class PageVisit
    {
        int numberOfVisits;
        string pageName;

        [DataMember]

        public string PageName
        {

            get { return pageName; }

            set { pageName = value; }

        }
        [DataMember]

        public int NumberOfVisits
        {

            get { return numberOfVisits; }

            set { numberOfVisits = value; }

        }

    }
}