using ContactList.Views;

namespace ContactList;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register the routes for your other pages here
        Routing.RegisterRoute(nameof(AddContactPage), typeof(AddContactPage));
        Routing.RegisterRoute(nameof(ContactDetailsPage), typeof(ContactDetailsPage));
    }
}