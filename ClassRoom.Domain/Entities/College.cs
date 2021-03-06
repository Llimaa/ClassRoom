﻿using ClassRoom.Domain.ValueObjects;
using ClassRoom.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ClassRoom.Domain.Entities
{
    public class College : Entity
    {
        private readonly IList<Address> _addresses;
        private readonly IList<Block> _blocks;
        private readonly IList<Course> _courses;

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IEnumerable<Address> Addresses => _addresses.ToArray<Address>();
        public IEnumerable<Block> blocks => _blocks.ToArray<Block>();
        public IEnumerable<Course> Cources => _courses.ToArray<Course>();
        public string Image { get; private set; }

        public College(Name name, Document document, Email email, string phone, string image)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = String.Join("", System.Text.RegularExpressions.Regex.Split(phone, @"[^\d]"));
            Image = image;
            _addresses = new List<Address>();
            _blocks = new List<Block>();
            _courses = new List<Course>();
        }

        public void AddAddress(Address address)
        {
            if (address.Valid)
                _addresses.Add(address);

            AddNotifications(address.Notifications);
        }

        public void AddBlock(Block block)
        {
            if (block.Valid)
                _blocks.Add(block);

            AddNotifications(block.Notifications);
        }

        public void AddCourse(Course course)
        {
            if (course.Valid)
                _courses.Add(course);

            AddNotifications(course.Notifications);
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
