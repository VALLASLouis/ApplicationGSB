using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class Auth
    {
        #region Propriétés
        private String login;
        private String password;


        #endregion

        #region Accesseurs 

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        #endregion

        public Auth(String unLogin, String unPassword)
        {
            login = unLogin;
            password = unPassword;
        }
    }
}
