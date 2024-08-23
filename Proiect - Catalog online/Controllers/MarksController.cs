using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Proiect___Catalog_online.Data;
using Proiect___Catalog_online.DTO;
using Proiect___Catalog_online.DTO.Extensions;
using Proiect___Catalog_online.Models;
using Proiect___Catalog_online.Services;
using System.Collections.Generic;
using System.Linq;

namespace Proiect___Catalog_online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : ControllerBase
    {

        private readonly MarksService marksService;
        private readonly StudentsRegistryDbContext ctx;


        public MarksController(MarksService marksService, StudentsRegistryDbContext ctx)
        {

            this.marksService = marksService;
            this.ctx = ctx;

        }
        [HttpPost]
        public Mark AddMark([FromBody] MarkToCreateDto markToCreateDto)
        {
            var mark = new Mark
            {
                MarkValue = markToCreateDto.MarkValue,
                StudentId = markToCreateDto.StudentId,
                SubjectId = markToCreateDto.SubjectId,
            };
            ctx.Marks.Add(mark);
            ctx.SaveChanges();
            return mark;
        }

        [HttpGet("{studentId}")]
        public ActionResult<IEnumerable<Mark>> GetMarksForStudent(int studentId)
        {
            var marks = ctx.Marks.Where(m => m.StudentId == studentId).ToList();

            if (marks == null)
            {
                return NotFound();
            }

            return Ok(marks);
        }

        [HttpGet("{studentId}, {subjectId}")]
        public ActionResult<IEnumerable<Mark>> GetMarksForStudent(int studentId, int subjectId)
        {
            var marks = ctx.Marks.Where(m => m.StudentId == studentId && m.SubjectId == subjectId).ToList();

            if (marks == null)
            {
                return NotFound();
            }

            return Ok(marks);
        }

        [HttpGet("student/{studentId}/averages")]
        public ActionResult<IEnumerable<SubjectAverageDto>> GetSubjectAveragesForStudent(int studentId)
        {
            var averages = marksService.GetSubjectAveragesForStudent(studentId);

            if (averages == null)
            {
                return NotFound();
            }

            return Ok(averages);
        }
    }
}
    
