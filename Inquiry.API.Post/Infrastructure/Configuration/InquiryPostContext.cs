using Inquiry.API.Post.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Inquiry.API.Post.Infrastructure.Configuration
{
    public class InquiryPostContext:DbContext
    {
        public InquiryPostContext(DbContextOptions<InquiryPostContext> options):base(options)
        {
            
        }
        public DbSet<ActionLog> ActionLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=InquiryPost;Integrated Security=True; MultipleActiveResultSets=True; Trust Server Certificate=True");
            }
        }
    }
}
