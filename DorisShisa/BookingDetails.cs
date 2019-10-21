using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DorisShisa
{
    public class BookingDetails
    {
        string name = string.Empty;
        string email = string.Empty;
        string cell = string.Empty;
        string numberOfPeople;
        DateTime dates;
        DateTime times;
        string requests;
        int bookingid;
       
       
        [DataMember]

        public int BookingID
        {

            get { return bookingid; }

            set { bookingid = value; }

        }
        
        [DataMember]

        public string Name
        {

            get { return name; }

            set { name = value; }

        }


        [DataMember]

        public string Email
        {

            get { return email; }

            set { email = value; }

        }

        [DataMember]

        public string Cell
        {

            get { return cell; }

            set { cell = value; }

        }


        public string NumberOfPeople
        {

            get { return numberOfPeople; }

            set { numberOfPeople = value; }

        }


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


        public string Request
        {

            get { return requests; }

            set { requests = value; }

        }


    }
}