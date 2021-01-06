using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ONEULApp.Data;
using ONEULApp.ViewModels;
using ONEULApp.Views;

namespace ONEULApp
{
    public static class Locator
    {
        private static IServiceProvider serviceProvider;

        public static void Initialize()
        {
            var services = new ServiceCollection();
            services.AddSingleton<OneulRepository, SqliteOneulRepository>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<WriteViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<WritePage>();

            serviceProvider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => serviceProvider.GetService<T>();
    }
}
