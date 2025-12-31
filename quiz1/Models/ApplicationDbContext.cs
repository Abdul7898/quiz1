using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using quiz1.Models.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<QuizQuestion> QuizQuestions { get; set; }  
}


