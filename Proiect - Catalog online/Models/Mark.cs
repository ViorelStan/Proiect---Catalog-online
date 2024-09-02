namespace Proiect___Catalog_online.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int MarkValue {  get; set; }

        public DateTime Moment { get; set; }

        public int SubjectId { get; set; }

        public int StudentId { get; set; }
        public Subject Subject { get; set; }

        public Mark()
        {
            this.Moment = DateTime.UtcNow;
        }
    }

}
