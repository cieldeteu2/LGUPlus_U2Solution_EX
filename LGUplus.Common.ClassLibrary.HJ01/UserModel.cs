using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGUplus.Common.ClassLibrary.HJ01
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    

        public String SaveUserData(UserModel user)
        {
            return "OK";
        }
    }
}
