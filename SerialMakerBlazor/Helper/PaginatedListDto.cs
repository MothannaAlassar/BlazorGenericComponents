using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Helper
{
    public class PaginatedListDto<T>
    {
        public List<T> Items { get; set; } // The list of items for the current page
        public int CurrentPage { get; set; } // The current page index
        public int TotalPages { get; set; } // Total number of pages
        public int TotalRecords { get; set; } // Total number of records
        public int PageSize { get; set; } // Number of items per page

        public PaginatedListDto(List<T> items, int count, int currentPage, int pageSize)
        {
            Items = items;
            TotalRecords = count;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }
    }
}
