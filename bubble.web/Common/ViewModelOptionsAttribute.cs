using System;

namespace bubble.web.Common
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ViewModelOptionsAttribute : Attribute
    {
        public string Source { get; set; }

        public ViewModelOptionsAttribute()
        {
            Source = "";
        }
        public ViewModelOptionsAttribute(string source)
        {
            Source = source;
        }
    }
}