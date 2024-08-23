using Proiect___Catalog_online.Models;

namespace Proiect___Catalog_online.DTO.Extensions
{
    public static class StudentExtensions
    {
        public static StudentToGetDto ToStudentToGet(this Student student)
        {
            if (student == null)
            {
                return null;
            }
            return new StudentToGetDto
            {
                LastName = student.LastName,
                FirstName = student.FirstName,
                Age = student.Age,
            };

            
        }
        public static Student ToEntity(this StudentToUpdate studentToCreate) =>
           new Student
           {
               FirstName = studentToCreate.FirstName,
               LastName = studentToCreate.LastName,
               Age = studentToCreate.Age
           };
    }
}
