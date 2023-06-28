using System;

namespace CleanArchMvc.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }

        /*public DateTime CreatedDate { get; protected set; }
        public string CreatedBy { get; protected set; }
        public DateTime? LastModifiedDate { get; protected set; }
        public string LastModifiedBy { get; protected set; }
        public bool IsDeleted { get; protected set; }
        public DateTime? DeletedDate { get; protected set; }
        public string DeletedBy { get; protected set; }*/
    }
}
