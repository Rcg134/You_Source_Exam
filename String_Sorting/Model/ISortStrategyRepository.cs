// <copyright file="ISortStrategy.cs" company="company="Yousource" createdby="Russel Gutierrez">
// Copyright (c) Yousource. All rights reserved.
// </copyright>

namespace String_Sorting.Model
{
    public interface ISortStrategyRepository
    {
        string BubbleSortStrategy(SortingModel input);

        string QuickSortStrategy(SortingModel input);

        string MergeSortStrategy(SortingModel input);
    }
}
