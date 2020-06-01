using ClassRoom.Shared;
using FluentValidator.Validation;
using System;

namespace ClassRoom.Domain.Entities
{
    public class Equipment : Entity
    {
        public string Description { get; private set; }
        public string Status { get; private set; }
        public DateTime PurchaseDate { get; private set; }

        public Equipment(string description)
        {
            Description = description;
            Status = "Free";
            PurchaseDate = DateTime.Now;

            Validate();
        }

        public Equipment(string description, string status, DateTime purchaseDate)
        {
            Description = description;
            Status = status;
            PurchaseDate = purchaseDate;

            Validate();
        }

        public void Book()
        {
            if (Status == "Free")
                Status = "Reserved";
            else
                AddNotification("Book", "Equipamento indisponível para reserva");
        }

        public void SetAsBroken()
        {
            if (Status != "Broken")
                Status = "Broken";
        }

        public override string ToString()
        {
            return Description;
        }

        private void Validate()
        {
            AddNotifications(new ValidationContract()
                .HasMinLen(Description, 3, "Description", "A descrição deve conter pelo menos 3 caracteres")
                .HasMaxLen(Description, 100, "Description", "A descrição deve conter no máximo 100 caracteres")
            );
        }
    }
}
