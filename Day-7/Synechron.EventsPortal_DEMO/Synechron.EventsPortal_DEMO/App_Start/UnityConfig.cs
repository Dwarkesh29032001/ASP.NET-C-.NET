using System.Web.Mvc;
using Synechron.EventsPortal.Dal;
using Synechron.EventsPortal_DEMO.DAL;
using Unity;
using Unity.Mvc5;

namespace Synechron.EventsPortal_DEMO
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
			//var container1 = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<EmployeeDal, EmployeeDal>();
            container.RegisterType<EventDal, EventDal>();
            container.RegisterType<SecurityDal, SecurityDal>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
          //  DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}