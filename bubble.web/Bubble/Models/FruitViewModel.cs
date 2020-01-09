using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using bubble.web.Bubble;
using bubble.web.Common;

namespace bubble.web.Bubble.Models
{
    [BubbleModel]
    public class FruitViewModel
    {

        [Fieldset(1, InputType.Select)]
        [Required]
        [ViewModelOptions]
        public string CategoryCode { get; set; } = "";

        [Fieldset(2, InputType.Text)]
        [Required]
        public string Name { get; set; } = "";

        public IEnumerable<KeyValuePair<string, string>> CategoryCodeOptions
        {
            get
            {
                yield return new KeyValuePair<string, string>("01", "柑橘類");
            }
        }
    }


}