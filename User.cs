using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        private static int nextId;
        public static string UserName = "Guest";

        public User(string name, string dateOfBirth, string phoneNumber)
        {
            Id = nextId++;
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }
    }
}
