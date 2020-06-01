using FluentValidator;
using FluentValidator.Validation;

namespace ClassRoom.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address ?? "";

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Address, "Email", "E-mail Inválido")
            );
        }

        public string Address { get; set; }
    }
}
