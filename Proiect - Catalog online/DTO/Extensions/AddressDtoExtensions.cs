using Proiect___Catalog_online.Models;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Proiect___Catalog_online.DTO.Extensions
{
    public static class AddressDtoExtensions
      
    {
        public static AddressToGetDto ToAddressToGet(this Address address)
        {
            if (address == null) 
                return null;
            return new AddressToGetDto
            {
                City = address.City,
                Street = address.Street,
                No = address.No,
            };
        }
    }
}
