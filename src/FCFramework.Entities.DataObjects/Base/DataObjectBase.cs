using System;

namespace FCFramework.Entities.DataObjects.Base
{
    public abstract class DataObjectBase
    {
        public virtual string UId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DataObjectStatus Status { get; set; }
        public string Notes { get; set; }
    
    }
}