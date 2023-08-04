using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class DataValidator

    {
        public static bool IsValidEmail(string email)
        {
            // Implement email validation logic (a simple example here)
            return email.Contains("@");
        }
    }
}
