using System.Collections;
using System.Collections.Generic;
using FCFramework.Entities.DataObjects.Base;

namespace FCFramework.Entities.DataObjects.Common
{
    public class CommunicationDetails : DataObjectBase
    {
        public CommunicationTypes CommunicationType { get; set; }
        public ICollection<Phone> Phone { get; set; }
        public ICollection<EMailAddress> EMailAddress { get; set; }
    }
}