namespace DotNote.Web.Models
{
    public class Update
    {
        public Guid UpdateId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
