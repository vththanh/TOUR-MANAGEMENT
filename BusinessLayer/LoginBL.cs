using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;
        public LoginBL()
        {
            loginDL = new LoginDL();
        }
        public bool Login(Account acc)
        {
            try
            {
                return loginDL.Login(acc);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
