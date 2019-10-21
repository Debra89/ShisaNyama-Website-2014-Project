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
    public class TaskDetails
    {
        int taskID;
        string cusname;
        string empname;
        int bookingid;
        string tableno;
        DateTime times;
        DateTime dates;
        int orderid;
       
        [DataMember]

        public string CusName
        {

            get { return cusname; }

            set { cusname = value; }

        }
        [DataMember]

        public int TaskID
        {

            get { return taskID; }

            set { taskID = value; }

        }
        [DataMember]

        public int BookingID
        {

            get { return bookingid; }

            set { bookingid = value; }

        }
        [DataMember]

        public int OrderID
        {

            get { return orderid; }

            set { orderid = value; }

        }

        [DataMember]

        public string EmpName
        {

            get { return empname; }

            set { empname = value; }

        }

        public string TableNo
        {

            get { return tableno; }

            set { tableno = value; }

        }
        [DataMember]

        public DateTime Dates
        {

            get { return dates; }

            set { dates = value; }

        }

        public DateTime Times
        {

            get { return times; }

            set { times = value; }

        }
    }
}