using Microsoft.EntityFrameworkCore;
using Proiect___Catalog_online.Data;
using Proiect___Catalog_online.DTO;

namespace Proiect___Catalog_online.Services
{
    public class SubjectsService
    {
        private readonly StudentsRegistryDbContext ctx;
        public SubjectsService(StudentsRegistryDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<SubjectToGetDto> GetAllSubjectNames()
        {
            return ctx.Subjects
                .Select(s => new SubjectToGetDto
                {
                    Name = s.Name
                })
                .ToList();
        }
    }
}
