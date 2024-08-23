using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect___Catalog_online.Data;
using Proiect___Catalog_online.Models;

namespace Proiect___Catalog_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        //    private readonly StudentsRegistryDbContext ctx;
        //    public SeedController(StudentsRegistryDbContext ctx)
        //    {
        //        this.ctx = ctx;
        //    }

        //    [HttpPost]
        //    public void Seed()
        //    {
        //        ctx.Students.Add(new Student
        //        {
        //            LastName = "Stan",
        //            FirstName = "Viorel",
        //            Age = 29,
        //            Adress = new Address
        //            {
        //                City = "Chiajna",
        //                Street = "Sergent Ilie Petre",
        //                No = 8

        //            }

        //        });
        //        ctx.SaveChanges();
        //    }
        //}
    }
}
