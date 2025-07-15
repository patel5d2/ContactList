using ContactList.ViewModels;

namespace ContactList.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(ContactDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}