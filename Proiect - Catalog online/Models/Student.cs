using System.Security.Cryptography.X509Certificates;

namespace Proiect___Catalog_online.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public Mark Mark { get; set; }
    }
}
