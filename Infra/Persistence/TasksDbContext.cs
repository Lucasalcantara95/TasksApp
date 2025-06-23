using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistence
{
	public class TasksDbContext(DbContextOptions options) : DbContext(options)
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Workspace> Workspaces { get; set; }
		public DbSet<ListCard> ListCards { get; set; }
		public DbSet<Card> Cards { get; set; }

	}
}
