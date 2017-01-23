using System.ComponentModel.DataAnnotations.Schema;

namespace January.Models
{
    [Table("topics")]
    public class Topic
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
    }
}