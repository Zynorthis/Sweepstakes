using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        public int registrationNumber;
        public string FirstName { get { return firstName; } private set { firstName = value; } }
        public string LastName { get { return lastName; } private set { lastName = value; } }
        public string EmailAddress { get { return emailAddress; } private set { emailAddress = value; } }

        public Contestant()
        {

        }
    }
}
