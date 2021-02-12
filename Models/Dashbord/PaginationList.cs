using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Pagination
{
    public class PaginationList<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPage { get; set; }
        public PaginationList(List<T> item, int count, int pageindex, int pagesize)
        {
            PageIndex = pageindex;
            TotalPage = (int)Math.Ceiling(count / (double)pagesize);
        }
        public bool PreviousPage
        {
            get => PageIndex > 1;
           
        }

        public bool NextPage
        {
            get => PageIndex < TotalPage;
           

        }
        public static async Task<PaginationList<T>> CreatePaginationAsync (IEnumerable<T> DataSource,int pageindex, int pagesize)
        {
            var count = DataSource.Count();
            var item = DataSource.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return new PaginationList<T>(item, count, pageindex, pagesize);
        }
    }
    

}
