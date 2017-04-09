using System.Data.Entity;

namespace TestASPApp.Models
{
	public class DBContext : System.Data.Entity.DbContext
	{
		public DBContext() : base("DbConnection"){}
		public DbSet<User> Users { get; set; }
	}
}