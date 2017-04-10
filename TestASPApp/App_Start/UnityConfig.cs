using System.Web.Mvc;
using Microsoft.Practices.Unity;
using TestASPApp.ModelsDTO;
using TestASPApp.Repositories;
using Unity.Mvc5;

namespace TestASPApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();
			container.RegisterType<IRepository<UserDTO, int>, UserRepository>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}