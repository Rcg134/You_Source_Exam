// <copyright file="SortingModel.cs" company="company="Yousource" createdby="Russel Gutierrez">
// Copyright (c) Yousource. All rights reserved.
// </copyright>

namespace String_Sorting.Model
{
    using System;
    using System.Text.RegularExpressions;

    public class SortingModel
    {
        private string? _inputString;

        public string? InputString
        {
            get => this._inputString;
            set
            {
                _inputString = value?.Trim();
                if (string.IsNullOrEmpty(_inputString))
                {
                    throw new ArgumentException("Input string cannot be null or empty.");
                }

                if (!Regex.IsMatch(_inputString, @"^[a-zA-Z0-9 ]*$"))
                {
                    throw new ArgumentException("Input string contains invalid characters.");
                }
            }
        }

        public enum SortingStrategy
        {
            QuickSort,
            MergeSort,
            BubbleSort,
        }
    }
}
