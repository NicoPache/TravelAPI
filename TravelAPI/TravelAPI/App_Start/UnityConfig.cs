using Services.Interfaces;
using Services.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.WebApi;
using Unity.Lifetime;

namespace TravelAPI.App_Start
{
    public static class UnityConfig
    {

        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IGestorTour, GestorTour>(new HierarchicalLifetimeManager());
            container.RegisterType<IGestorReserva, GestorReserva>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    } 
}