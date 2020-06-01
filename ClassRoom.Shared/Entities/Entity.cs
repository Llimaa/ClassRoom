using FluentValidator;
using FluentValidator.Validation;
using System;

namespace ClassRoom.Shared
{
    public class Entity : Notifiable
    {
        public Guid Id { get; private set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            Id = id;
            AddNotifications(new ValidationContract()
               .HasMinLen(Id.ToString(), 32, "Entity", "Identificador inválido")
           );
        }
    }
}
