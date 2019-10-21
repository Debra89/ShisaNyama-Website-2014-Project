using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DorisShisa
{
    public class ProductsDetails
    {
        int productID;
        string name;
        string description;
        string category;
        decimal price;
        string imageUrl;

        [DataMember]

        public int ProductID
        {

            get { return productID; }

            set { productID = value; }

        }

        [DataMember]

        public string Name
        {

            get { return name; }

            set { name = value; }

        }




        [DataMember]

        public string Description
        {

            get { return description; }

            set { description = value; }

        }


        public string Category
        {
            get { return category; }

            set { category = value; }

        }


        public decimal Price
        {

            get { return price; }

            set { price = value; }

        }

        public string ImageUrl
        {

            get { return imageUrl; }

            set { imageUrl = value; }


        }



    }
}