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
    public class ReportDetails
    {
        string date;
        int number;

        [DataMember]
        public string Date
        {

            get { return date; }

            set { date= value; }

        }
        [DataMember]
        public int Number 
        {

            get { return number; }

            set { number = value; }

        }


    }
}