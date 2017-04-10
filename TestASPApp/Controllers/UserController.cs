using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using TestASPApp.Models;
using TestASPApp.ModelsDTO;
using TestASPApp.Repositories;

namespace TestASPApp.Controllers
{
	public class UserController : Controller
	{
		private readonly IRepository<UserDTO, int> _repository;

		public UserController(IRepository<UserDTO, int> repo)
		{
			_repository = repo;
		}

		// GET: User
		public ActionResult Index()
		{
			var users = _repository.Get();
			return View(users);
		}

		// GET: User/List
		public ActionResult List()
		{
			var users = _repository.Get();
			return PartialView("_List", users);
		}

		// GET: User/Create
		public ActionResult Create()
		{
			var user = new UserDTO();
			return PartialView("_Create", user);
		}

		// POST: User/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public HttpResponseMessage Create(UserDTO user)
		{
			if (!ModelState.IsValid)
			{
				return new HttpResponseMessage(HttpStatusCode.BadRequest);
			}
			_repository.Add(user);
			return new HttpResponseMessage(HttpStatusCode.Created);
		}

		// GET: User/Edit/5
		public ActionResult Edit(int id)
		{
			var user = _repository.Get(id);
			return PartialView("_Edit", user);
		}

		// POST: User/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public HttpResponseMessage Edit(UserDTO user)
		{
			if (!ModelState.IsValid)
			{
				return new HttpResponseMessage(HttpStatusCode.BadRequest);
			}
			_repository.Update(user);
			return new HttpResponseMessage(HttpStatusCode.OK);
		}

		// GET: User/Delete/5`
		public ActionResult Delete(int id)
		{
			var user = _repository.Get(id);
			return PartialView("_Delete", user);
		}

		// POST: User/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public void Delete(UserDTO user)
		{
			if (!ModelState.IsValid)
			{
				return;
			}
			_repository.Remove(user);
		}
	}
}