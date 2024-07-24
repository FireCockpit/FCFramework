using System.Collections;
using System.Collections.Generic;
using FCFramework.Entities.DataObjects.Base;
using FCFramework.Entities.DataObjects.Documents;
using FCFramework.Entities.DataObjects.HumanResources;

namespace FCFramework.Entities.DataObjects.PublicRessources
{
    public class Contributor : DataObjectBase
    {
        public string ContributorNumber { get; set; }
        public ICollection<Agreement> Aggreements { get; set; }
        public ICollection<Document> Documents { get; set; }
        public Person Person { get; set; }
    }
}