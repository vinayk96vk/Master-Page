using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dallib;
namespace CustomerBLlib
{
    public class CustomerBL
    {
        CustomerDAL dal;
        public CustomerBL()
        {
            dal = new CustomerDAL();
        }
        public string CheckLogin(string un, string pass)
        {
            string _role=null;
            if (un == null || pass == null)
                _role = null;

            else
                   _role = dal.CheckLoginDb(un, pass);
               
            
            return _role;
            
    }
    }
}
