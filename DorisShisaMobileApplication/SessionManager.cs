using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DorisShisaMobileApplication
{ /*! 
    Session manager manages webusers logged in the mobile application
       */
    class SessionManager
    {
        private static Dictionary<string, object> session = new Dictionary<string, object>();

        public static Dictionary<string, object> Session
        {
            get { return SessionManager.session; }
            set { SessionManager.session = value; }
        }


    }
}
