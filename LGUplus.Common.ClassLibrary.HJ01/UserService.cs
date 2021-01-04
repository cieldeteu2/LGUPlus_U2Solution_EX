using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGUplus.Common.ClassLibrary.HJ01
{
    public class UserService
    {

        public string SaveUserData(UserModel user)
        {
            Debug.WriteLine($"입력 사용자 이름은 { user.UserName } 입니다");
            return "ok";


        }
        public UserModel GetUserData(string userid)
        {
            UserModel user = new UserModel();
            user.UserName = "이호준";
            user.UserEmail = "cieldete@naver.com";

            return user;

        }

    }
}
