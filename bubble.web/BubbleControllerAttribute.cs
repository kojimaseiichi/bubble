using System;

namespace bubble.web
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BubbleControllerAttribute : Attribute
    {
        public string Route { get; set; }

        public BubbleControllerAttribute(string route)
        {
            Route = route;
        }
    }
}