using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel;

namespace SportShop.Infrastructure
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        //nadpisujemy domyślny sposób tworzenia kontrolerów
        private readonly IKernel _kernel; //Kernel to worek w ktorym są zarejestrowane wszystkie klasy, metody itd.

        public WindsorControllerFactory(IKernel kernel)
        {
            _kernel = kernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404, $"Controller for path {requestContext.HttpContext.Request.Path} could not be found");
            }

            
            return (IController)_kernel.Resolve(controllerType); // metoda pobierająca z worka kontroler który zarejestrowaliśmy w kontenerze
        }

        public override void ReleaseController(IController controller)
        {
            _kernel.ReleaseComponent(controller); // czyścimy kontroler z worka
        }
    }
}