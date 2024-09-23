using String_Sorting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Sorting.Controller
{
    public class SortStrategyController
    {
        private readonly ISortStrategyRepository _sortStrategyRepository;

        public SortStrategyController(ISortStrategyRepository sortStrategyRepository)
        {
            this._sortStrategyRepository = sortStrategyRepository;
        }

        //public string Sort
    }
}
