using ClassRoom.Domain.Enuns;
using FluentValidator;
using FluentValidator.Validation;
using System.Runtime.InteropServices.ComTypes;

namespace ClassRoom.Domain.Entities
{
    public class ClassRoom : Notifiable
    {

        public string Description { get; private set; }
        public EClassRoomStatus Status { get; private set; }
        public EClassRoomStatus Type { get; private set; }

        public ClassRoom(string description, EClassRoomStatus status, EClassRoomStatus type)
        {
            Description = description;
            Status = EClassRoomStatus.Free;
            Type = EClassRoomStatus.Free;

            Description = description;
            Status = status;
            Type = type;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Description, 5, "Description", "O campo deve ter pelo menos 5 caracteres")
                .HasMaxLen(Description, 60, "Description", "O campo deve ter no máximo 60 caracteres")
            );
        }


        public void Book()
        {
            if (Status == EClassRoomStatus.Free)
                Status = EClassRoomStatus.Reserved;
        }

        public void SetAsUnvaiable()
        {
            if (Status != EClassRoomStatus.Unavailable)
                Status = EClassRoomStatus.Unavailable;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}