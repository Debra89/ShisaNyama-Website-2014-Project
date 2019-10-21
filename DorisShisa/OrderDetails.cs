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
    public class OrderDetails
    {

        string productID;
        int orderid;
        string name;
        string email;
        string price;
        DateTime orderdate;


        [DataMember]

        public DateTime OrderDate
        {

            get { return orderdate; }

            set { orderdate = value; }

        }
        [DataMember]

        public int OrderID
        {

            get { return orderid; }

            set { orderid = value; }

        }
        [DataMember]

        public string ProductName
        {

            get { return name; }

            set { name = value; }

        }
        [DataMember]

        public string ProductID
        {

            get { return productID; }

            set { productID = value; }

        }

        [DataMember]

        public string CustomerEmail
        {

            get { return email; }

            set { email = value; }

        }

        public string ProductPrice
        {

            get { return price; }

            set { price = value; }

        }

    }
}