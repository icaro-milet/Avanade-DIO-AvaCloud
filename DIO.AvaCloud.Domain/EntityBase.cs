using System;

namespace DIO.AvaCloud.Domain
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public abstract bool Validate();
    }
}
