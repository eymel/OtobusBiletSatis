using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyTicketService.Model;
using BusinessLayer;
using Entity;

namespace MyTicketService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {

        UserBusiness _uBll = new UserBusiness();
        public UserModel Login(LoginModel user)
        {
            User userresult= _uBll.Login(user.Email, user.Password);
            UserModel _user = new UserModel();
            _user.Name = userresult.Name;
            _user.LastName = userresult.LastName;
            _user.UserID = userresult.UserID;
            _user.UserType = userresult.UserType;
            return _user;

        }
    }
}
