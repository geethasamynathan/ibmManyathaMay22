﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Customer
    {
        private string _firstname;
        private string _lastname;

        public string Firstname {
            get { return _firstname; } 
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        //public string GetFullName()
        //{
        //    return _firstname + " " + _lastname;
        //}
    }
}
