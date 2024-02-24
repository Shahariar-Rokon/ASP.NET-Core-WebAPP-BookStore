using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestV1.Models
{
    public class BookDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BID { get; set; }
        [ForeignKey("StudentMaster")]
        public int SID { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public StudentMaster StudentMaster { get; set; }
    }
}
