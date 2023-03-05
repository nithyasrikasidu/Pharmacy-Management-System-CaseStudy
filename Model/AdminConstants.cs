using System.Collections.Generic;

namespace Pharmacy_Management_System.Model
{
    public class AdminConstants
    {
        public static List<Admin> _admin = new List<Admin>()
        {
            new Admin(){AdminName="admin2",Contact="1234567891",EmailId="admin2@gmail.com",Password="admin2",Role="administrator" },
            new Admin(){AdminName="admin",Contact="1234567895",EmailId="admin@gmail.com",Password="admin",Role="administrator"},
            new Admin(){AdminName="MainAdmin",Contact="9912674321",EmailId="vtu14218@veltech.edu.in",Password="admin",Role="administrator"}
        };
    }
}
