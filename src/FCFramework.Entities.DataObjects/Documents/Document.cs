using FCFramework.Entities.DataObjects.Base;
using FCFramework.Entities.DataObjects.HumanResources;

namespace FCFramework.Entities.DataObjects.Documents
{
    public class Document : DataObjectBase
    {
        public string DocumentNumber { get; set; }
        public string Description { get; set; }
        public string DocumentType { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentName { get; set; }
        public string DocumentExtension { get; set; }
        public string DocumentSize { get; set; }
        public string DocumentContentType { get; set; }
        public string DocumentContent { get; set; }
        public Person Signee { get; set; }
    }
}