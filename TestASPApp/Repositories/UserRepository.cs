using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Linq;
using TestASPApp.Models;

namespace TestASPApp.Repositories
{
	public class UserRepository : IRepository<User, int>
	{
		[Dependency]
		public DBContext Context { get; set; }

		public IEnumerable<User> Get()
		{
			return Context.Users.ToList();
		}

		public User Get(int id)
		{
			return Context.Users.Find(id);
		}

		public void Add(User entity)
		{
			Context.Users.Add(entity);
			Context.SaveChanges();
		}

		public void Remove(User entity)
		{
			var obj = Context.Users.Find(entity.Id);
			if (obj != null) Context.Users.Remove(obj);
			Context.SaveChanges();
		}

		public void Update(User entity)
		{
			var obj = Context.Users.Find(entity.Id);
			if (obj != null)
			{
				obj.Email = entity.Email;
				obj.Name = entity.Name;
				obj.PhoneNumber = entity.PhoneNumber;
				obj.SecondName = entity.SecondName;
			}
			Context.SaveChanges();
		}
	}
}