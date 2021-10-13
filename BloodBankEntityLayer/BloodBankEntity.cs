using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankEntityLayer
{
    public class Donor
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> Contact { get; set; }
        public Nullable<int> AadharNumber { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string City { get; set; }
        public string HealthCondition { get; set; }
        public Nullable<int> IsDonor { get; set; }
    }

    public class BloodBank
    {

    }
}
