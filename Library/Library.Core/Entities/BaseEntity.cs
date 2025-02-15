using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
