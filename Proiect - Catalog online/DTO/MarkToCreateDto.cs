using Proiect___Catalog_online.Models;
using System.ComponentModel.DataAnnotations;

namespace Proiect___Catalog_online.DTO
{
    public class MarkToCreateDto
    {

        [Range(1, 10)]
        public int MarkValue { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }

    }
}
