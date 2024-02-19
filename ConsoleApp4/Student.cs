using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCSharp
{
    public class Student
    {
        private string firstName = "Erick";
        private string lastname = "Kurniawan";

        public string getFullName()
        {
            return $"{firstName} {lastname}";
        }

        public string getFullName(string firstName, string lastname)
        {
            return $"{firstName} {lastname}";
        }
    }
}
