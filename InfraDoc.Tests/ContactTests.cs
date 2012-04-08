using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using InfraDoc.Data;
using InfraDoc.Data.Filters;
using InfraDoc.Data.Interfaces;
using InfraDoc.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfraDoc.Tests
{
    [TestClass]
    public class ContactTests
    {
        ContactService contactService;
        [TestInitialize]
        public void Setup()
        {
            IContactRepository rep = new TestContactRepository();
            contactService = new ContactService(rep);
        }

        [TestMethod]
        public void Contact_ShouldHave_Name_PhoneNumber_Email_Site_Fields()
        {
            Contact c = new Contact(1, "TestName","666-666-6666", "test@user.com");

            Assert.AreEqual(1, c.SiteId);
            Assert.AreEqual("TestName", c.Name);
            Assert.AreEqual("666-666-6666", c.Phone);
            Assert.AreEqual("test@user.com", c.Email);
        }

        [TestMethod]
        public void ContactRepository_Contains_Contacts()
        {
            IContactRepository rep = new TestContactRepository();
            Assert.IsNotNull(rep.GetContacts());
        }

        [TestMethod]
        public void ContactService_Contains_Contains()
        {
            IList<Contact> contacts = contactService.GetContacts();
            Assert.IsNotNull(contacts);
        }

        [TestMethod]
        public void ContactRepository_Has_Site_Filter_For_Contacts()
        {
            IContactRepository rep = new TestContactRepository();

            IList<Contact> contacts = rep.GetContacts()
                .WithSite(1)
                .ToList();

            Assert.IsNotNull(contacts);
        }

        [TestMethod]
        public void ContactRepository_SiteFilter_Returns_2_Contacts_With_Site_1()
        {
            IContactRepository rep = new TestContactRepository();

            IList<Contact> contacts = rep.GetContacts()
                .WithSite(1).ToList();

            Assert.AreEqual(2, contacts.Count);
        }

        [TestMethod]
        public void ContactService_Returns_2_Contacts_With_Site_1()
        {
            IList<Contact> contacts = contactService.GetContactsBySite(1);
            Assert.AreEqual(2, contacts.Count);
        }

        [TestMethod]
        public void ContactRepository_Returns_Single_Contact_When_Filtered_ByID_1()
        {
            IContactRepository rep = new TestContactRepository();

            IList<Contact> contacts = rep.GetContacts()
                .WithID(1).ToList();

            Assert.AreEqual(1, contacts.Count);
        }

        [TestMethod]
        public void ContactService_Returns_Single_Contact_With_ContactID_1()
        {
            Contact c = contactService.GetContactByID(1);
            Assert.IsNotNull(c);
        }
    }
}
