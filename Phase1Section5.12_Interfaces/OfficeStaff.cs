﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._12_Interfaces
{
    public class OfficeStaff : IPerson
    {
        private string name;
        private string address;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

        public string getInfo()
        {
            string retVal = "Name: " + name + ", Address=" + address + ", Joining Date =" + dateOfJoining.ToShortDateString();
            return retVal;
        }

        public string getTypeOfPerson()
        {
            return "OfficeStaff";
        }
    }
}
