using System.Collections.Generic;
using FCFramework.Entities.DataObjects.Base;
using FCFramework.Entities.DataObjects.PublicRessources;

namespace FCFramework.Entities.DataObjects.Documents
{
    public class Agreement : DataObjectBase
    {
        public string AgreementNumber { get; set; }
        public string Description { get; set; }
        public ICollection<Document> AgreementDocuments { get; set; }
    }
    
}