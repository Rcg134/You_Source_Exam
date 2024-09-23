// <copyright file="SortStrategyController.cs" company="Yousource">
// Copyright (c) Yousource. All rights reserved.
// </copyright>

namespace String_Sorting.Controller
{
    using String_Sorting.Model;

    public class SortStrategyController
    {
        private readonly ISortStrategyRepository _sortStrategyRepository;

        public SortStrategyController(ISortStrategyRepository sortStrategyRepository)
        {
            this._sortStrategyRepository = sortStrategyRepository;
        }
    }
}
