using Microsoft.EntityFrameworkCore;
using Proiect___Catalog_online.Data;
using Proiect___Catalog_online.DTO;
using Proiect___Catalog_online.DTO.Extensions;
using Proiect___Catalog_online.Models;

namespace Proiect___Catalog_online.Services
{
    public class AddressesService
    {
        private readonly StudentsRegistryDbContext ctx;
        public AddressesService(StudentsRegistryDbContext ctx)
        {
            this.ctx = ctx;
        }

        public AddressToGetDto GetAddressById(int id) =>
           ctx.Address.FirstOrDefault(a => a.Id == id).ToAddressToGet();
            public Address AddAddress(string City, string Street, int No)
        {
            var address = ctx.Address.FirstOrDefault(s => s.City == City && s.Street == Street && s.No == No);
            if (address != null)
            {
                return address;
            }

            address = new Address { City = City, Street = Street, No = No};
            ctx.Address.Add(address);
            ctx.SaveChanges();
            return address;

        }
    }
}
