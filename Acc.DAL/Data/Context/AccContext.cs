using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class AccContext: DbContext
{
	public DbSet<Student> students { get; set; }
	public DbSet<Course> cources { get; set; }
    public DbSet<Teacher> teachers { get; set; }
 

    public AccContext(DbContextOptions<AccContext> options): base(options)
	{
		
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<StudentCources>()
			.HasKey(a => new { a.StdId, a.CrsId });
		base.OnModelCreating(modelBuilder);
	}
}
