using FluentValidator;
using FluentValidator.Validation;

namespace ClassRoom.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Validate();
        }

        public void Change(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Validate();
        }

        private void Validate()
        {
            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(FirstName, 3, "FirstName", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 20, "FirstName", "O nome deve conter no maximo 20 caracteres")
                .HasMinLen(LastName, 3, "LastName", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(LastName, 20, "LastName", "O nome deve conter no maximo 20 caracteres")
            );
        }
    }
}
