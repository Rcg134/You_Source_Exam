namespace String_Sorting.Model
{
    using System;
    using System.Collections.Generic;
    using static String_Sorting.Model.SortingModel;

    public class DictionaryEnumsMapper
    {
        private readonly ISortStrategyRepository _sortStrategyRepository;

        public DictionaryEnumsMapper(ISortStrategyRepository sortStrategyRepository)
        {
            this._sortStrategyRepository = sortStrategyRepository;
        }

        public string Sort(SortingModel sortingModel, SortingStrategy strategy)
        {
            var results = new Dictionary<SortingStrategy, Func<string>>
            {
                { SortingStrategy.QuickSort, () => this._sortStrategyRepository.QuickSortStrategy(sortingModel) },
                { SortingStrategy.MergeSort, () => this._sortStrategyRepository.MergeSortStrategy(sortingModel) },
                { SortingStrategy.BubbleSort, () => this._sortStrategyRepository.BubbleSortStrategy(sortingModel) },
            };

            if (results.TryGetValue(strategy, out var action))
            {
                return action.Invoke();
            }

            throw new InvalidOperationException("Sorting strategy not found.");
        }
    }
}
