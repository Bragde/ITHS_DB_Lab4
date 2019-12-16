using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Session> Sessions { get; set; }

        public override string ToString()
        {
            return $@"{this.FirstName} {this.LastName} {this.Email}";
        }
    }
}
