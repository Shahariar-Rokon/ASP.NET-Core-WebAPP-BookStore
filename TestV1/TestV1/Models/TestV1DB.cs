using System.Data.Entity;

namespace TestV1.Models
{
    public class TestV1DB:DbContext
    {
        public DbSet<StudentMaster> studentMasters { get; set; }
        public DbSet<BookDetail> bookDetails { get; set; }
    }
}
