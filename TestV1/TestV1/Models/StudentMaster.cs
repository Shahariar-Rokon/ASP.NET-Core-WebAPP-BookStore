using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestV1.Models
{
    public class StudentMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SID { get; set; }
        [Required(ErrorMessage = "GetGood")]
        public string? SName { get; set; }
        public int? SAge { get; set; }
        public DateTime? SDate { get; set; }
        public string? SPhoto { get; set; }
        public virtual IList<BookDetail>? BookDetails { get; set; }
    }
}
