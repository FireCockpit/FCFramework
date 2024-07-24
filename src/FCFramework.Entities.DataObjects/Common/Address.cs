using System.Runtime.CompilerServices;
using FCFramework.Entities.DataObjects.Base;

namespace FCFramework.Entities.DataObjects.Common
{
    public class Address : DataObjectBase
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public AddressTypes AddressType { get; set; }
    }
}