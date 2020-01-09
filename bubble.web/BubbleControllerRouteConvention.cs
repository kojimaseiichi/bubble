using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace bubble.web
{

    public class BubbleControllerRouteConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType == false || controller.ControllerType.GenericTypeArguments.Length != 2)
            if (controller.ControllerType.IsGenericType)
            {
                var genericAppType = controller.ControllerType.GenericTypeArguments[0];
                var genericModelType = controller.ControllerType.GenericTypeParameters[1];
                var customNameAttribute = genericAppType.GetCustomAttribute<BubbleControllerAttribute>();

                if (customNameAttribute?.Route != null)
                {
                    controller.Selectors.Add(new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel(new RouteAttribute(customNameAttribute.Route)),
                    });
                }
            }
        }
    }
}