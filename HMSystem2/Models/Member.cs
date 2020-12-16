using System;

namespace HMSystem.Models
{
    public abstract class Member
    {
        public Member(string firstName, string lastName, long phoneNumber, string address) {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string FullName {
            get {
                return LastName + ", " + FirstName;
            }
        }

    }
}