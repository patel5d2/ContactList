using ContactList.Models;
using ContactList.ViewModels;
using ContactList.Views;

namespace ContactList.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage(ContactsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Models.Contact selectedContact)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedContact", selectedContact }
            };
            await Shell.Current.GoToAsync(nameof(ContactDetailsPage), navigationParameter);
        }
    }

    private async void OnAddNewContactClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddContactPage));
    }
}