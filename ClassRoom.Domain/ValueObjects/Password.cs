using FluentValidator;
using FluentValidator.Validation;
using System.Security.Cryptography;
using System.Text;

namespace ClassRoom.Domain.ValueObjects
{
    public class Password : Notifiable
    {
        public string Value { get; set; }
        public Password(string value)
        {
            Value = value ?? "";
            Validade();
        }

        public void Encrypt()
        {
            byte[] temp;

            SHA1 sha = new SHA1CryptoServiceProvider();
            temp = sha.ComputeHash(Encoding.UTF8.GetBytes(Value));

            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < temp.Length; index++)
                stringBuilder.Append(temp[index].ToString("x2"));

            Value = stringBuilder.ToString();
        }

        public void Change(string newValue)
        {
            Value = newValue;
            Validade();
        }

        private void Validade()
        {
            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Value, 6, "Password", "A senha deve ter no minimo 5 caracteres")
                .HasMaxLen(Value, 10, "Passeord", "A senha deve ter no maximo 10 caracteres")
            );
            Encrypt();
        }
    }
}
