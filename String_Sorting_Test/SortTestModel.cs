// <copyright file="SortTestModel.cs" company="Yousource">
// Copyright (c) Yousource. All rights reserved.
// </copyright>

namespace String_Sorting_Test
{
    public class SortTestModel
    {
        private string? _expectedOutput = string.Empty;

        public string? ExepectedInput
        {
            get => this._expectedOutput;
            set => this._expectedOutput = value?.ToLower();
        }

        public string? ExpectedOutput { get; set; }
    }
}
