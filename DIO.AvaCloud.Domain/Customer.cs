using System;
using System.Collections.Generic;

namespace DIO.AvaCloud.Domain
{
    public class Customer : EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Int64 Document { get; set; }

        public List<Address> Addresses { get; set; }

        public DateTime Birthday { get; set; }

        public string FullName 
        {
            get 
            {
                string fullname = FirstName;

                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    fullname += $" {LastName}";
                }

                return fullname;
            }
        }

        public override string ToString() => 
            $"Nome completo: {FullName} | Email: {Email} | Data de nascimento: {Birthday}";

        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(FirstName);
        }
    }
}
