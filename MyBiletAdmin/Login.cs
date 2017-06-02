using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBiletAdmin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserServiceReferences.UserModel user = UserLogin(textBox1.Text,textBox2.Text);
            if (user!=null)
            {
                switch (user.UserType)
                {
                    case UserServiceReferences.UserType.User:
                        break;
                    case UserServiceReferences.UserType.Manager:
                        Manager frm = new Manager(user);
                        frm.Show();
                        this.Hide();
                        break;
                    case UserServiceReferences.UserType.Employee:
                        Employee frme = new Employee(user);
                        frme.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Kullanıcı Adı ve ya Şifre Yanlış");
                        break;
                }
            }
        }

        public UserServiceReferences.UserModel  UserLogin(string email ,string password) {
            UserServiceReferences.UserServiceClient userClient= new UserServiceReferences.UserServiceClient();
            UserServiceReferences.LoginModel user = new UserServiceReferences.LoginModel { Email = email, Password = password };
           return userClient.Login(user);
          

        }

    }
}
