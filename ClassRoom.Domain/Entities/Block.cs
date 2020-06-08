using FluentValidator;
using FluentValidator.Validation;

namespace ClassRoom.Domain.Entities
{
    public class Block : Notifiable
    {
        public string Description { get; private set; }

        public Block(string description)
        {
            Description = description ?? "";

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Description, 3, "Description", "O campo deve conter pelo menos 3 caracteres")
                .HasMaxLen(Description, 50, "Description", "O campo deve conter no máximo 50 caracteres")
            );
        }
    }
}
