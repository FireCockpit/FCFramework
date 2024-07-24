using System.Collections.Generic;
using FCFramework.Entities.DataObjects.Base;
using FCFramework.Entities.DataObjects.Comman;
using FCFramework.Entities.DataObjects.Common;

namespace FiFramework.Entities.DataObjects.PublicRessources
{
    public class Organisation : DataObjectBase
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public OrganisationTypes OrganisationType { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<CommunicationDetails> CommunicationDetails { get; set; }
    }
}