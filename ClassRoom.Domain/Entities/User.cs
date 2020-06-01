using ClassRoom.Domain.ValueObjects;
using ClassRoom.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom.Domain.Entities
{
    public class User : Entity
    {
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public string Phone { get; private set; }
        public string Status { get; private set; }
        public string Image { get; private set; }

        public User(Email email, Password password)
        {
            Email = email;
            Password = password;
        }

        public User(Name name, Document document, Email email, Password password, string phone, string status, string image)
        {
            Name = name;
            Document = document;
            Email = email;
            Password = password;
            Phone = phone.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
            Status = status;
            Image = image;
        }

        public void ChangePhone(string phone)
        {
            if (!string.IsNullOrEmpty(phone))
                Phone = phone;
        }

        public void ChangeStatus(string status)
        {
            Status = status;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
