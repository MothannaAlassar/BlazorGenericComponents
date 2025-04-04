using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Helpers
{
    public class GridColumn<T>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public Func<T, object> PropertySelector { get; set; }
        public bool IsFilterable { get; set; } = false;
        public bool IsSortable { get; set; } = true;
        public bool IsComboFilter { get; set; } = false;
        public List<string> DataSourceForCombo { get; set; }
        public Func<T, Task> Action { get; set; }
        public string CssClass { get; set; }
        public string RowCssClass { get; set; }
    }
    public class GenericItem<T> where T : class
    {
        public T Item { get; set; }
    }
}
