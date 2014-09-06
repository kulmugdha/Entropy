using Microsoft.AspNet.Mvc.ReflectedModelBuilder;
using System.Text;

namespace NamespaceRouting
{
    internal class NameSpaceRoutingConvention : IReflectedApplicationModelConvention
    {
        public void OnModelCreated(ReflectedApplicationModel model)
        {
            foreach (var controller in model.Controllers)
            {
                if (controller.AttributeRouteModel == null)
                {
                    //Create new attribute Route for the controller
                    controller.AttributeRouteModel = new ReflectedAttributeRouteModel();

                    //Just replace the . in the namespace with a / to create the attribute route 
                    // Ex: MySite.Admin namespace will corrospond to MySite/Admin attribute route                    
                    controller.AttributeRouteModel.Template = controller.ControllerType.Namespace.Replace('.', '/');                    
                }

                //You can continue to put attribute route templates for the controller actions depending on the way you want them to behave
            }
        }
    }
}