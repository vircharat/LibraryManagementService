﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class User
    {
        public string Email { get; set; }
        public int UserId { get; set; }

        public string UserName { get; set; }    
        public string UserPassword { get; set; }

    }
}
