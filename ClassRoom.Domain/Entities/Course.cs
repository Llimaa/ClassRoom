﻿using ClassRoom.Shared;
using FluentValidator.Validation;

namespace ClassRoom.Domain.Entities
{
    public class Course : Entity
    {
        public string Description { get; private set; }

        public Course(string description)
        {
            Description = description ?? "";

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Description, 2, "Course", "A descrição deve conter pelo menos 2 caracteres")
                .HasMaxLen(Description, 50, "Course", "A descrição deve conter no máximo 50 caracteres")
            );
        }
    }
}
