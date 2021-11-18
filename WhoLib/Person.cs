using System;

namespace WhoLib
{
    public class Person
    {
        private string firstname, lastname;
        private DateTime birthDate;

        public Person(string firstname, string lastname, DateTime birthDate)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthDate = birthDate;
        }

        //properties
        public string Firstname
        {
            get
            {
                return firstname;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return birthDate;
            }
        }
    }
}
