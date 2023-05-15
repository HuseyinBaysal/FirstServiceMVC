using System;

namespace FirstServiceMVC.Infrastructure.Entities.Abstract
{
    public enum Status { Active = 1, Modified,Passive}

    public abstract class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get => _createdDate; set => _createdDate=value; }

        public DateTime? UpdateDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

        private DateTime _deletedDate = DateTime.Now;
        public DateTime DeletedDate { get => _deletedDate; set => _deletedDate = value; }
    }
}
