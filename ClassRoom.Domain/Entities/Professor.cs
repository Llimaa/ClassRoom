using ClassRoom.Domain.ValueObjects;
using ClassRoom.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom.Domain.Entities
{
    public class Professor : Entity
    {
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Course Course { get; private set; }
        public string Phone { get; private set; }
        public string Status { get; private set; }

        public Professor(Name name, Document document, Email email, Course course, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Course = course;
            Phone = String.Join("", System.Text.RegularExpressions.Regex.Split(phone, @"[^\d]"));
            Status = "Active";

            AddNotifications(Name.Notifications);
            AddNotifications(Document.Notifications);
            AddNotifications(Email.Notifications);
            AddNotifications(Course.Notifications);
        }

        public void Inactivate()
        {
            Status = "Inactive";
        }

        public void Activate()
        {
            Status = "Active";
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
