using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness
    {
        UnitOfWork _db;
        public UserBusiness()
        {
            _db = new UnitOfWork();
        }
     
        public static bool IsEmailUnique(string email)
        {
            UserBusiness userbll = new UserBusiness();
            User emailControl = (from u in userbll.GetAll()
                                 where u.Email == email
                                 select u).FirstOrDefault();
            if (emailControl==null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool SignUp(User user)
        {
              
            //TODO : Diğer boş gelme durumları kontol Edilecek

           
       
   
            try
            {
                _db.UserRepository.Add(user);
                bool result = _db.ApplyChanges();
                if (result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public User Login(string userName, string password)
        {

            if (string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password))
                throw new Exception("Lütfen Doğru Bilgiler giriniz.");
            User user = _db.UserRepository.GetAll().Where(x =>  x.Email == userName && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }



        }
        public bool Update(User user)
        {
            if (user != null)
            {
                _db.UserRepository.Update(user);
                return _db.ApplyChanges();
            }
            return false;
        }

        public bool Delete(User user)
        {
            if (user != null)
            {
                _db.UserRepository.Delete(user);
                return _db.ApplyChanges();
            }
            return false;
        }
        public User Get(int id)
        {
            return _db.UserRepository.Get(id);

        }
        public List<User> GetAll()
        {

            return _db.UserRepository.GetAll();
        }


      


    }
}
