// <copyright file="HandleExeptions.cs" company="YouSource">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace String_Sorting.Filters
{
    public static class ExceptionHandler
    {
        public static void HandleException(Exception ex) =>
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
