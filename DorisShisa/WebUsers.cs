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
    public class WebUsers
    {
  string name = string.Empty;

        string surname = string.Empty;

        string cell = string.Empty;
        
        string email = string.Empty;
        string password;
        string userLevel;
        
        


        
        [DataMember]

        public string Password
        {

            get { return password; }

            set { password = value; }

        }

      


        [DataMember]

        public string UserLevel
        {

            get { return userLevel; }

            set { userLevel = value; }

        }




        [DataMember]

        public string Name
        {

            get { return name; }

            set { name = value; }

        }

        [DataMember]

        public string Surname
        {

            get { return surname; }

            set { surname = value; }

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


    }

    }
