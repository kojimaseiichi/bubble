using System;

namespace bubble.web.Common
{
    public enum InputType
    {
        Text,
        Select,
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FieldsetAttribute : Attribute
    {
        public int Order { get; set; } = 0;

        InputType InputType { get; set; } = InputType.Text;

        public FieldsetAttribute(int order, InputType inputType)
        {
            Order = order;
            InputType = inputType;
        }
    }
}