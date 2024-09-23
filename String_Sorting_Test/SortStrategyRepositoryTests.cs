using String_Sorting.Model;

namespace String_Sorting_Test
{
    public class SortStrategyRepositoryTests: IClassFixture<SortStrategyRepository>
    {
        private readonly SortStrategyRepository _sortStrategyRepository;

        public SortStrategyRepositoryTests(SortStrategyRepository sortStrategyRepository)
        {
            this._sortStrategyRepository = sortStrategyRepository;
        }

        public static IEnumerable<object[]> SortingTestData()
        {
            yield return new object[] { new SortTestModel { exepectedInput = "russel", expectedOutput = "elrssu" } };
            yield return new object[] { new SortTestModel { exepectedInput = "ake", expectedOutput = "aek" } };
        }

        [Theory]
        [MemberData(nameof(SortingTestData))]
        public void BubbleSortStrategy_SortsCorrectly(SortTestModel testData)
        {
            // Arrange
            var input = new SortingModel { InputString = testData.exepectedInput };

            // Act
            var result = _sortStrategyRepository.BubbleSortStrategy(input);

            // Assert
            Assert.Equal(testData.expectedOutput, result);
        }

        [Theory]
        [MemberData(nameof(SortingTestData))]
        public void MergeSortStrategy_SortsCorrectly(SortTestModel testData)
        {
            // Arrange
            var input = new SortingModel { InputString = testData.exepectedInput };

            // Act
            var result = _sortStrategyRepository.MergeSortStrategy(input);

            // Assert
            Assert.Equal(testData.expectedOutput, result);
        }

        [Theory]
        [MemberData(nameof(SortingTestData))]
        public void QuickSortStrategy_SortsCorrectly(SortTestModel testData)
        {
            // Arrange
            var input = new SortingModel { InputString = testData.exepectedInput };

            // Act
            var result = _sortStrategyRepository.QuickSortStrategy(input);

            // Assert
            Assert.Equal(testData.expectedOutput, result);
        }


    }
}
