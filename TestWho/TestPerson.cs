using NUnit.Framework;
using System;
using WhoLib;

namespace TestWho
{
    public class TestPerson
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Person_Constructor_3items_Success()
        {
            //given
            string expected_firstname = "Nolan";
            string expected_lastname = "Evard";
            DateTime expected_birthdate = DateTime.Parse("05/09/2003");

            //When
            Person testPerson = new("Nolan", "Evard", DateTime.Parse("05/09/2003"));

            //Then
            Assert.AreEqual(expected_firstname, testPerson.Firstname);
            Assert.AreEqual(expected_lastname, testPerson.Lastname);
            Assert.AreEqual(expected_birthdate, testPerson.Birthdate);
        }
    }
}