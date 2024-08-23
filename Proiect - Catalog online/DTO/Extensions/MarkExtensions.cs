using Proiect___Catalog_online.DTO;
using Proiect___Catalog_online.Models;

namespace Proiect___Catalog_online.DTO.Extensions
{
    public static class MarkExtensions
    {
        public static MarkToGetDto GetAllMarks(this Mark mark)
        {
            return new MarkToGetDto
            {
                MarkValue = mark.MarkValue,
                StudentId = mark.StudentId,
                Moment = mark.Moment,
                SubjectId = mark.SubjectId,
            };
        }
    }
}