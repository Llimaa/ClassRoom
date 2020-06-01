using FluentValidator;
using FluentValidator.Validation;

namespace ClassRoom.Domain.Entities
{
    public class ClassRoom : Notifiable
    {

        public string Description { get; private set; }
        public string Status { get; private set; }
        public string Type { get; private set; }

        public ClassRoom(string description, string status, string type)
        {
            Description = description;
            Status = status;
            Type = type;

            Description = description;
            Status = status;
            Type = type;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Description, 2, "Description", "O campo deve ter pelo menos 2 caracteres")
                .HasMaxLen(Description, 60, "Description", "O campo deve ter no máximo 60 caracteres")
            );
        }


        public void Book()
        {
            if (Status == "Free")
                Status = "Reserved";
        }

        public void SetAsUnvaiable()
        {
            if (Status != "Unavailable")
                Status = "Unavailable";
        }

        public override string ToString()
        {
            return Description;
        }
    }
}