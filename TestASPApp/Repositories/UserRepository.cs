using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TestASPApp.Models;
using TestASPApp.ModelsDTO;

namespace TestASPApp.Repositories
{
	public class UserRepository : IRepository<UserDTO, int>
	{
		[Dependency]
		public DBContext Context { get; set; }
		

		public IEnumerable<UserDTO> Get()
		{
			Mapper.Initialize(cfg => cfg.CreateMap<User, UserDTO>());
			return Mapper.Map<IQueryable<User>, IEnumerable<UserDTO>>(Context.Users);
		}

		public UserDTO Get(int id)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<User, UserDTO>());
			return Mapper.Map<User, UserDTO>(Context.Users.Find(id));
		}

		public void Add(UserDTO entity)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<UserDTO, User>());
			var user = Mapper.Map<UserDTO, User>(entity);
			Context.Users.Add(user);
			Context.SaveChanges();
		}

		public void Remove(UserDTO entity)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<UserDTO, User>());
			var user = Mapper.Map<UserDTO, User>(entity);
			var obj = Context.Users.Find(user.Id);
			if (obj != null) Context.Users.Remove(obj);
			Context.SaveChanges();
		}

		public void Update(UserDTO entity)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<UserDTO, User>());
			var user = Mapper.Map<UserDTO, User>(entity);
			var obj = Context.Users.Find(user.Id);
			if (obj != null)
			{
				obj.Email = entity.Email;
				obj.FirstName = entity.FirstName;
				obj.PhoneNumber = entity.PhoneNumber;
				obj.LastName = entity.LastName;
			}
			Context.SaveChanges();
		}
	}
}