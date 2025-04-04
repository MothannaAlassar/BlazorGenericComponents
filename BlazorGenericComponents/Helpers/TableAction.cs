using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Helpers
{
    public class TableAction<TItem>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string HrefUrl { get; set; }
        public object KeyUrlParam { get; set; }
        public Func<TItem, object> PropertySelector { get; set; }
        public Func<TItem, Task> Action { get; set; }
        public bool IsVisible { get; set; } = true; // Flag to check if the action should be displayed
    }
}
