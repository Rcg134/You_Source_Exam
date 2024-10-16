// <copyright file="SortStrategyRepositoryTests.cs" company="Yousource">
// Copyright (c) Yousource. All rights reserved.
// </copyright>

namespace String_Sorting_Test
{
    using String_Sorting.Model;

    public class SortStrategyRepositoryTests: IClassFixture<SortStrategyRepository>
    {
        private readonly SortStrategyRepository _sortStrategyRepository;

        public SortStrategyRepositoryTests(SortStrategyRepository sortStrategyRepository)
        {
            this._sortStrategyRepository = sortStrategyRepository;
        }

        public static IEnumerable<object[]> SortingTestData()
        {
            yield return new object[] { new SortTestModel { ExepectedInput = "russeL", ExpectedOutput = "elrssu" } };
            yield return new object[] { new SortTestModel { ExepectedInput = "akE", ExpectedOutput = "aek" } };
        }

        [Theory]
        [MemberData(nameof(SortingTestData))]
        public void BubbleSortStrategy_SortsCorrectly(SortTestModel testData)
        {
            // Arrange
            var input = new SortingModel { InputString = testData.ExepectedInput };

            // Act
            var result = this._sortStrategyRepository.BubbleSortStrategy(input);

            // Assert
            Assert.Equal(testData.ExpectedOutput, result);
        }

        [Theory]
        [MemberData(nameof(SortingTestData))]
        public void MergeSortStrategy_SortsCorrectly(SortTestModel testData)
        {
            // Arrange
            var input = new SortingModel { InputString = testData.ExepectedInput };

            // Act
            var result = this._sortStrategyRepository.MergeSortStrategy(input);

            // Assert
            Assert.Equal(testData.ExpectedOutput, result);
        }

        [Theory]
        [MemberData(nameof(SortingTestData))]
        public void QuickSortStrategy_SortsCorrectly(SortTestModel testData)
        {
            // Arrange
            var input = new SortingModel { InputString = testData.ExepectedInput };

            // Act
            var result = this._sortStrategyRepository.QuickSortStrategy(input);

            // Assert
            Assert.Equal(testData.ExpectedOutput, result);
        }

        [Fact]
        public void InputString_NullOrEmpty_ThrowsArgumentException()
        {
            // Arrange
            var model = new SortingModel();
            var input = string.Empty;
            var expectedOutput = "Input string cannot be null or empty.";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                model.InputString = input;
            });

            Assert.Equal(expectedOutput, exception.Message);
        }

        [Fact]
        public void InputString_InvalidCharacters_ThrowsArgumentException()
        {
            // Arrange
            var model = new SortingModel();
            var input = "Invalid@String";
            var expectedOutput = "Input string contains invalid characters.";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                model.InputString = input; // String with special characters
            });

            Assert.Equal(expectedOutput, exception.Message);
        }
    }
}
