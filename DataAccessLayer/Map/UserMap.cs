﻿using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap() 
        {
            HasKey(x => x.UserID);


        }

    }
}
