using ContactList.ViewModels;
using ContactList.Views;
using Microsoft.Extensions.Logging;

namespace ContactList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            // Registering services for dependency injection
            builder.Services.AddSingleton<ContactsViewModel>();
            builder.Services.AddSingleton<ContactsPage>();

            builder.Services.AddTransient<AddContactViewModel>();
            builder.Services.AddTransient<ContactDetailViewModel>(); // Corrected typo here

            builder.Services.AddTransient<AddContactPage>();
            builder.Services.AddTransient<ContactDetailsPage>();

            return builder.Build();
        }
    }
}