// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace String_Sorting
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using String_Sorting.Filters;
    using String_Sorting.Model;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Subscribe to the UI thread exception handler
            Application.ThreadException += (sender, e) => ExceptionHandler.HandleException(e.Exception);

            // Subscribe to the non-UI thread exception handler
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    ExceptionHandler.HandleException(ex);
                }
            };

            // Create a new service collection
            var services = new ServiceCollection();

            // Register dependencies
            services.AddScoped<ISortStrategyRepository, SortStrategyRepository>();
            services.AddScoped<DictionaryEnumsMapper>();

            // Register the MainFormView
            services.AddScoped<MainFormView>(); // Make sure the form is registered here

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            // Get the MainFormView from the service provider
            var mainForm = serviceProvider.GetService<MainFormView>();

            if (mainForm != null)
            {
                // Run the application with the main form
                Application.Run(mainForm);
            }
            else
            {
                // Handle the case where MainFormView could not be resolved
                MessageBox.Show("Main form could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}