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
    public partial class Employee : Form
    {
        UserServiceReferences.UserModel _user;
        public Employee(UserServiceReferences.UserModel user)
        {
            InitializeComponent();
            _user = user;
        }
    }
}
