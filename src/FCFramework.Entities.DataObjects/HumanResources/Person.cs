using System.Collections;
using System.Collections.Generic;
using FCFramework.Entities.DataObjects.Base;
using FCFramework.Entities.DataObjects.Common;

namespace FCFramework.Entities.DataObjects.HumanResources
{
    public class Person : DataObjectBase
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CommunicationDetails> CommunicationDetails { get; set; }
    }
}